using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.Business;
using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;


using System.Net;
using System.Net.Mail;
using System.IO;

using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace BoilerSupplier.Webapi.Controllers
{
    public class MailController : Controller
    {

        private SqlConnection con;
        private SqlCommand com;





        //Invitation mail
        [HttpPost]
        public int InvitationMail(Invitation invitation)
        {


            int result = 0;
            try
            {

                string emailId = invitation.LoginEmailID;

                SmtpClient client = new SmtpClient();
                MailMessage mail = new MailMessage();

                System.Net.NetworkCredential smtpCrede = new System.Net.NetworkCredential(clsCommon.UserName1, clsCommon.Password1);

                string subject = clsCommon.InvitationOTPSubject;
                client.Host = clsCommon.MailHostName;
                client.Port = Convert.ToInt32(clsCommon.Port);
                client.UseDefaultCredentials = true;
                client.Credentials = smtpCrede;
                client.EnableSsl = true;
                MailAddress to = new MailAddress(emailId);
                MailAddress from = new MailAddress(clsCommon.MailFrom);
                mail.Subject = subject;

                //using (StreamReader reader = new StreamReader(System.Web.HttpContext.Current.Server.MapPath("~/NotifyMail.html")))
                //{
                //    mail.Body = reader.ReadToEnd();
                //}
                string webapi = clsCommon.WebServiceURL;
                mail.Body = mail.Body.Replace("{firstname}", invitation.FirstName);
                mail.Body = mail.Body.Replace("{lastname}", invitation.LastName);
                mail.Body = mail.Body.Replace("{PurchasingOrgName}", invitation.PurchasingOrgName);
                mail.Body = mail.Body.Replace("{SignUpLink}", webapi + "/SignUp.aspx?SignUpID=" + invitation.LoginEmailID + "&" + "PurOrg=" + invitation.PurchasingOrgName);
                mail.IsBodyHtml = true;

                mail.From = from;
                mail.To.Add(to);

                if (clsCommon.BCCMailId != "")
                {
                    mail.Bcc.Add(clsCommon.BCCMailId);
                }
                else
                {
                    mail.Bcc.Add(clsCommon.BCCMailIdDef);
                }

                com = new SqlCommand("USP_InsertVendorLoginDetails", con);

                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FirstName", invitation.FirstName);
                com.Parameters.AddWithValue("@LastName", invitation.LastName);
                com.Parameters.AddWithValue("@EmailID", invitation.LoginEmailID);
                com.Parameters.AddWithValue("@PurchasingOrgID", invitation.PurchasingOrgID);
                com.Parameters.AddWithValue("@PurchasingOrgName", invitation.PurchasingOrgName);
                com.Parameters.AddWithValue("@Invitedby", invitation.Invitedby);
                com.Parameters.AddWithValue("@CompanyName", invitation.CompanyName);
                com.Parameters.AddWithValue("@ContactNo", invitation.ContactNo);
                com.Parameters.AddWithValue("@PurOrgCode", invitation.PurOrgCode);

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    result = Convert.ToInt32(dt.Rows[0]["result"].ToString());
                    string InviteID = dt.Rows[0]["InviteID"].ToString();
                    mail.Body = mail.Body.Replace("{InviteID}", InviteID);
                    client.Send(mail);
                }

                else
                {
                    result = Convert.ToInt32(dt.Rows[0]["result"].ToString());
                }
            }
            catch (Exception ex)
            {
                //clsCommon.LogError(ex);
                return result;

            }
            return result;
        }



        //OTP mail
        [HttpPost]
        public void OTPMail(string EmailID)
        {
            try
            {

                string emailId = EmailID;
                string SignUpID = EmailID;


                SmtpClient client1 = new SmtpClient();
                MailMessage mail = new MailMessage();


                System.Net.NetworkCredential smtpCrede = new System.Net.NetworkCredential(clsCommon.UserName1, clsCommon.Password1);
                string subject = clsCommon.RegistrationOTPSubject;
                client1.Host = clsCommon.MailHostName;
                client1.Port = Convert.ToInt32(clsCommon.Port);
                client1.UseDefaultCredentials = true;
                client1.Credentials = smtpCrede;
                client1.EnableSsl = true;
                MailAddress to = new MailAddress(emailId);
                MailAddress from = new MailAddress(clsCommon.MailFrom);
                mail.Subject = subject;
                //using (StreamReader reader = new StreamReader(System.Web.HttpContext.Current.Server.MapPath("~/OTPSignMail.html")))
                //{
                //    mail.Body = reader.ReadToEnd();
                //}

                string OTP = Convert.ToString(clsCommon.RandomNumber(100001, 999999));

                //Session["SignUpOTP"] = OTP;



                mail.Body = mail.Body.Replace("{firstname}", clsCommon.GetFirstLastName(SignUpID).Rows[0]["FirstName"].ToString());
                mail.Body = mail.Body.Replace("{lastname}", clsCommon.GetFirstLastName(SignUpID).Rows[0]["LastName"].ToString());

                mail.Body = mail.Body.Replace("{OTP}", OTP);
                mail.IsBodyHtml = true;
                mail.From = from;
                mail.To.Add(to);
                mail.Bcc.Add(clsCommon.BCCMailId);
                client1.Send(mail);

                //btnSendOTP.Enabled = false;
                //txtOTP.Enabled = true;


                string timevalue = Convert.ToString(clsCommon.TimeOut);
                //lblTimemins.Text = "Your OTP is valid for " + timevalue + " mins.";
                //lblTimemins.Visible = true;

                //lblSignUp.Text = "OTP is sent to your email ID";



            }
            catch (Exception ex)
            {
                //clsCommon.LogError(ex);
            }
        }


        //Sendback mail
        [HttpPost]
        private void SendbackMail(string VendorEmailID, string VendorCode)
        {

            try
            {
                SmtpClient client1 = new SmtpClient();
                MailMessage mail = new MailMessage();

                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";


                string emailId = VendorEmailID;
                System.Net.NetworkCredential smtpCrede = new System.Net.NetworkCredential(clsCommon.UserName1, clsCommon.Password1);
                string subject = clsCommon.QueriesSubject;
                client1.Host = clsCommon.MailHostName;
                client1.Port = Convert.ToInt32(clsCommon.Port);
                client1.UseDefaultCredentials = true;
                client1.Credentials = smtpCrede;
                client1.EnableSsl = true;
                MailAddress to = new MailAddress(emailId);
                MailAddress from = new MailAddress(clsCommon.MailFrom);
                mail.Subject = subject;
                mail.Body = PopulateBody(VendorEmailID, VendorCode);
                mail.IsBodyHtml = true;
                mail.From = from;
                mail.To.Add(to);
                if (clsCommon.BCCMailId != "")
                {
                    mail.Bcc.Add(clsCommon.BCCMailId);
                }
                else
                {

                }
                client1.Send(mail);
            }
            catch (Exception ex)
            {
                //clsCommon.LogError(ex);
            }
        }

        private string PopulateBody(string VendorEmailID, string VendorCode)
        {
            string SignUpID = VendorEmailID;

            string firstname = clsCommon.GetFirstLastName(SignUpID).Rows[0]["FirstName"].ToString();
            string lastname = clsCommon.GetFirstLastName(SignUpID).Rows[0]["LastName"].ToString();

            string FullName = firstname + " " + lastname;

            string body = "Dear " + FullName + ",<p>We have gone through your Supplier Registration Application <strong>" + VendorCode + "</strong>. We request you to go through below observation(s) and make necessary</p>" +
          "<p> changes as requested and re-submit your application.</p>";
            //            string body = "Dear" + "" + firstname +" "+ lastname +",<p>We have gone through your Supplier Registration Application '"+userName+"'. We request you to go through below observation(s) and make necessary</p>" +
            //"<p> changes as requested and re-submit your application.</p>";

            body += "<table border=1 cellspacing=0 >";
            body += "<tr><th>Srl</th><th>Reference Field</th><th>Tata Technologies Observation</th></tr>";

            //DataTable dt = Session["Table"] as DataTable;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{

            //    body += "<tr bgcolor=#BFBFBF style=font-family:Verdana;font-size:15px;><td>" + Convert.ToString(i + 1) + "." + "</td>";
            //    body += "<td>" + dt.Rows[i]["HyperlinkId"] + "</td>";
            //    body += "<td>" + dt.Rows[i]["Remarks"] + "</td></tr>";
            //}

            body += "</table>";
            //body += "We request you to Update &amp; Complete Supplier Registration Form &amp; submit it to become a Registered Business Partner with TTL.";
            body += "<br>";

            body += "<p><strong>Best Regards,</strong></p>";
            body += "<p><strong>Tata Technologies Global Sourcing Team</strong></p>";
            body += "&nbsp;";


            return body;
        }
    }
}
