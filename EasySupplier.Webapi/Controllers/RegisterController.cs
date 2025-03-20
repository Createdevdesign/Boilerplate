using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.Business;
using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;

using System.Web.Helpers;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

using Newtonsoft.Json;
using Nancy.Json;

using Microsoft.Extensions.Configuration;



namespace BoilerSupplier.Webapi.Controllers
{

    

    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private IConfiguration _config;
        private string vendorsapjson;
        private string withholdingjson;
        private string TaxExemptionjson;

        protected readonly string Sapapiurl;
        protected readonly string sapusername;
        protected readonly string sappassword;

        public RegisterController(IConfiguration config)
        {
            _config = config;
            //UAT
            Sapapiurl = _config.GetSection("SAPUat").GetSection("Sapapiurl").Value;
            sapusername = _config.GetSection("SAPUat").GetSection("sapusername").Value;
            sappassword = _config.GetSection("SAPUat").GetSection("sappassword").Value;
            //Production
            Sapapiurl = _config.GetSection("SAPProd").GetSection("Sapapiurl").Value;
            sapusername = _config.GetSection("SAPProd").GetSection("sapusername").Value;
            sappassword = _config.GetSection("SAPProd").GetSection("sappassword").Value;
        }


        // GET: api/<RegisterController>
        [HttpGet]
        public void Get()
        {

        }

        // GET api/<RegisterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<RegisterController>
        [HttpPost]
        //public void Post([FromBody] Register Register)
        public ActionResult<IEnumerable<Register>> Post([FromBody] Register register)
        {
            ActionResult response;
            var RegisterService = ServiceProxy.RegisterService;
            var RegisterData = RegisterService.InsertRegister(
                new Register
                {
                    VendorCode = register.VendorCode,
                    LoginEmailID = register.LoginEmailID,

                    PageSize = 10,
                    CurrentPage = 1,
                    MODE = "I"
                });
            if (RegisterData != null)
            {
                //Get vendor SAP tabel details
                VendorSAP vendorSAP = new VendorSAP();
                vendorSAP.VendorCode = register.VendorCode;
                vendorSAP.LoginEmailID = register.LoginEmailID;

                var VendorSAP = GetVendorSAPDetails(vendorSAP);

                if (VendorSAP!=null)
                {
                    vendorsapjson = "{\r\n\"Ekorg\":\"" + VendorSAP.Ekorg + "\" ,\r\n\"Lifnr\":\"" + VendorSAP.Lifnr + "\" ,\r\n\"Land1\":\"" + VendorSAP.Land1 + "\" ,\r\n\"Name1\":\"" + VendorSAP.Name1 + "\" ,\r\n\"Ort01\":\"" + VendorSAP.Ort01 + "\" ,\r\n\"Pstlz\":\"" + VendorSAP.Pstlz + "\" ,\r\n\"Regio\":\"" + VendorSAP.Regio + "\" ,\r\n\"Sort1\":\"" + VendorSAP.Sort1 + "\" ,\r\n\"Stras\":\"" + VendorSAP.Stras + "\" ,\r\n\"HouseNum1\":\"" + VendorSAP.HouseNum1 + "\" ,\r\n\"Anred\":\"" + VendorSAP.Anred + "\" ,\r\n\"StrSuppl1\":\"" + VendorSAP.StrSuppl1 + "\" ,\r\n\"StrSuppl2\":\"" + VendorSAP.StrSuppl2 + "\",\r\n\"StrSuppl3\":\"" + VendorSAP.StrSuppl3 + "\",\r\n\"Stcd1\":\"" + VendorSAP.Stcd1 + "\" ,\r\n\"Telf2\":\"" + VendorSAP.Telf2 + "\" ,\r\n\"Stcd3\":\"" + VendorSAP.Stcd3 + "\" ,\r\n\"Stceg\":\"" + VendorSAP.Stceg + "\" ,\r\n\"Stenr\":\"" + VendorSAP.Stenr + "\" ,\r\n\"Banks\":\"" + VendorSAP.Banks + "\" ,\r\n\"Bankl\":\"" + VendorSAP.Bankl + "\" ,\r\n\"Bankn\":\"" + VendorSAP.Bankn + "\" ,\r\n\"Bkont\":\"" + VendorSAP.Bkont + "\" ,\r\n\"Bkref\":\"" + VendorSAP.Bkref + "\" ,\r\n\"Koinh\":\"" + VendorSAP.Koinh + "\" ,\r\n\"SmtpAddr1\":\"" + VendorSAP.SmtpAddr1 + "\" ,\r\n\"SmtpAddr2\":\"" + VendorSAP.SmtpAddr2 + "\" ,\r\n\"SmtpAddr3\":\"" + VendorSAP.SmtpAddr3 + "\" ,\r\n\"SmtpAddr4\":\"" + VendorSAP.SmtpAddr4 + "\" ,\r\n\"SmtpAddr5\":\"" + VendorSAP.SmtpAddr5 + "\" ,\r\n\"Akont\":\"" + VendorSAP.Akont + "\",\r\n\"Mindk\":\"" + VendorSAP.Mindk + "\" ,\r\n\"Cerdt\":\"" + VendorSAP.Cerdt + "\",\r\n\"Zterm\":\"" + VendorSAP.Zterm + "\" ,\r\n\"Reprf\":\"" + VendorSAP.Reprf + "\" ,\r\n\"Zsabe\":\"" + VendorSAP.Zsabe + "\" ,\r\n\"Waers\":\"" + VendorSAP.Waers + "\" ,\r\n\"Kalsk\":\"" + VendorSAP.Kalsk + "\" ,\r\n\"Webre\":\"" + VendorSAP.Webre + "\" ,\r\n\"Xnbwy\":\"" + VendorSAP.Xnbwy + "\" ,\r\n\"Lebre\":\"" + VendorSAP.Lebre + "\" ,\r\n\"ZtermComp\":\"" + VendorSAP.ZtermComp + "\" ,\r\n\"VenClass\":\"" + VendorSAP.VenClass + "\" ,\r\n\"J1tpbupl\":\"" + VendorSAP.J1tpbupl + "\" ,\r\n\"Name2\":\"" + VendorSAP.Name2 + "\" ,\r\n\"TelNumber\":\"" + VendorSAP.TelNumber + "\" ,\r\n\"FaxNumber\":\"" + VendorSAP.FaxNumber + "\" ,\r\n\"Iban\":\"" + VendorSAP.Iban + "\" ,\r\n\"BankType\":\"" + VendorSAP.BankType + "\" ,\r\n\"Swift\":\"" + VendorSAP.Swift + "\" ,\r\n\"Zuawa\":\"" + VendorSAP.Zuawa + "\" ,\r\n\"Zwels\":\"" + VendorSAP.Zwels + "\" ,\r\n\"Zahls\":\"" + VendorSAP.Zahls + "\" ,\r\n\"Hbkid\":\"" + VendorSAP.Hbkid + "\" ,\r\n\"Qland\":\"" + VendorSAP.Qland + "\"";

                    if (VendorSAP.Ekorg == "3000")
                    {
                        //Get WithholdingTaxExe tabel Details
                        WithholdingTaxExe withholdingTaxExe = new WithholdingTaxExe();
                        withholdingTaxExe.VendorCode = VendorSAP.VendorCode;
                        withholdingTaxExe.Ekorg = VendorSAP.Ekorg;
                        var WithholdingTaxExe = GetWithholdingTaxExemptionDetails(withholdingTaxExe);

                            if(WithholdingTaxExe!=null)
                            {
                            TaxExemptionjson = "[\r\n{\r\n\"Ekorg\" : \"" + WithholdingTaxExe.Ekorg + "\" ,\r\n\"Witht\" : \"" + WithholdingTaxExe.WITHT + "\" ,\r\n\"WtWithcd\" : \"" + WithholdingTaxExe.WT_WITHCD + "\" ,\r\n\"WtWtexrs\" : \"" + WithholdingTaxExe.WT_WTEXRS + "\" ,\r\n\"WtExnr\" : \"" + WithholdingTaxExe.WT_EXNR + "\" ,\r\n\"WtExrt\" : \"" + WithholdingTaxExe.WT_EXRT + "\" ,\r\n\"WtExdf\" : \"" + WithholdingTaxExe.WT_EXDF + "\" ,\r\n\"WtExdt\" : \"" + WithholdingTaxExe.WT_EXDT + "\" ,\r\n\"SecCode\" : \"" + WithholdingTaxExe.SECCODE + "\" ,\r\n\"FiwtinExemThr\" : \"" + WithholdingTaxExe.FIWTIN_EXEM_THR + "\" ,\r\n\"Waers\" : \"" + WithholdingTaxExe.WAERS + "\"\r\n}\r\n]";
                            }
                            else
                            {
                            //WithholdingTaxExe empty json country india but not insert data
                            string WtExrtvalue = "0.00";
                            string FiwtinExemThrvalue = "0.00";
                            TaxExemptionjson = "[\r\n{\r\n\"Ekorg\" : \"\" ,\r\n\"Witht\" : \"\" ,\r\n\"WtWithcd\" : \"\" ,\r\n\"WtWtexrs\" : \"\" ,\r\n\"WtExnr\" : \"\" ,\r\n\"WtExrt\" : \"" + WtExrtvalue + "\" ,\r\n\"WtExdf\" : \"\" ,\r\n\"WtExdt\" : \"\" ,\r\n\"SecCode\" : \"\" ,\r\n\"FiwtinExemThr\" : \"" + FiwtinExemThrvalue + "\" ,\r\n\"Waers\" : \"\"\r\n}\r\n]";
                            }

                        //Get WithholdingTax tabel Details
                        WithholdingTax withholdingTax = new WithholdingTax();
                        withholdingTax.VendorCode = VendorSAP.VendorCode;
                        withholdingTax.Ekorg = VendorSAP.Ekorg;
                        var WithholdingTax = GetWithholdingTaxDetails(withholdingTax);
                        if (WithholdingTax != null)
                        {
                            withholdingjson = "[\r\n{\r\n\"Ekorg\" : \"" + WithholdingTax.Ekorg + "\" ,\r\n\"Witht\" : \"" + WithholdingTax.WITHT + "\" ,\r\n\"WtWithcd\" : \"" + WithholdingTax.WT_WITHCD + "\" ,\r\n\"Qsrec\" : \"" + WithholdingTax.QSREC + "\"\r\n}\r\n]";
                        }
                        else
                        {
                            //WithholdingTax empty json country india but not insert data
                            withholdingjson = "[\r\n{\r\n\"Ekorg\" : \"\" ,\r\n\"Witht\" : \"\" ,\r\n\"WtWithcd\" : \"\" ,\r\n\"Qsrec\" : \"\"\r\n}\r\n]";

                        }
                    }
                    else
                    {
                        //WithholdingTaxExe json other country
                        string WtExrtvalue = "0.00";
                        string FiwtinExemThrvalue = "0.00";
                        TaxExemptionjson = "[\r\n{\r\n\"Ekorg\" : \"\" ,\r\n\"Witht\" : \"\" ,\r\n\"WtWithcd\" : \"\" ,\r\n\"WtWtexrs\" : \"\" ,\r\n\"WtExnr\" : \"\" ,\r\n\"WtExrt\" : \"" + WtExrtvalue + "\" ,\r\n\"WtExdf\" : \"\" ,\r\n\"WtExdt\" : \"\" ,\r\n\"SecCode\" : \"\" ,\r\n\"FiwtinExemThr\" : \"" + FiwtinExemThrvalue + "\" ,\r\n\"Waers\" : \"\"\r\n}\r\n]";


                        //WithholdingTax json other country

                        withholdingjson = "[\r\n{\r\n\"Ekorg\" : \"\" ,\r\n\"Witht\" : \"\" ,\r\n\"WtWithcd\" : \"\" ,\r\n\"Qsrec\" : \"\"\r\n}\r\n]";

                    }
                   
                    //UAT Method call
                    //callSAPAPIUAT(vendorSAP);

                    //Production Method call                                    
                    //callSAPAPI(vendorSAP);


                }
                response = Ok(new
                {
                    status = 0,
                    data = RegisterData

                });
            }
            else
            {
                response = Ok(new
                {
                    status = 1,
                    data = RegisterData

                });
            }
            return response;
        }

       
        private VendorSAP GetVendorSAPDetails(VendorSAP vendorSAP)
        {
            var VendorSAPService = ServiceProxy.VendorSAPService;
            var VendorSAPData = VendorSAPService.GetVendorSAPData(
                   new VendorSAP
                   {
                       VendorCode = vendorSAP.VendorCode,
                       LoginEmailID = vendorSAP.LoginEmailID,
                     

                       PageSize = 10,
                       CurrentPage = 1,
                       MODE = "R"
                   });
            return VendorSAPData;

        }

        private WithholdingTaxExe GetWithholdingTaxExemptionDetails(WithholdingTaxExe withholdingTaxExe)
        {
            var WithholdingTaxExeListService = ServiceProxy.WithholdingTaxExeListService;
            var WithholdingTaxExeListData = WithholdingTaxExeListService.GetWithholdingTaxExeListData(
                   new WithholdingTaxExe
                   {
                       VendorCode = withholdingTaxExe.VendorCode,
                       Ekorg = withholdingTaxExe.Ekorg,


                       PageSize = 10,
                       CurrentPage = 1,
                       MODE = "R"
                   });
            return WithholdingTaxExeListData;
        }


        private WithholdingTax GetWithholdingTaxDetails(WithholdingTax withholdingTax)
        {
           var WithholdingTaxListService = ServiceProxy.WithholdingTaxListService;
            var WithholdingTaxListData = WithholdingTaxListService.GetWithholdingTaxListData(
                   new WithholdingTax
                   {
                       VendorCode = withholdingTax.VendorCode,
                       Ekorg = withholdingTax.Ekorg,


                       PageSize = 10,
                       CurrentPage = 1,
                       MODE = "R"
                   });
            return WithholdingTaxListData;
        }


        protected void callSAPAPIUAT(VendorSAP vendorSAP)
        {
            try
            {
                string token = "";

                string json1 = vendorsapjson + "," + "\"CINSet\" : " + TaxExemptionjson + "," + "\"WthTaxAccSet\" : " + withholdingjson + "}";
               
                clsCommon.jsonStatus(json1.ToString());

                string json = JsonConvert.SerializeObject(json1);

                CookieContainer cookieJar = new CookieContainer();

                //here u can call api , api link will be mentioned in web.config

                //var TARGETURL = clsCommon.Sapapiurl;
                //here u can call api , api link will be mentioned in appsettings
                var TARGETURL = Sapapiurl;


                Console.WriteLine("GET: + " + TARGETURL);
                var handler = new HttpClientHandler();
                // ... Use HttpClient.            
                HttpClient client = new HttpClient(handler);
                // here u can usernam and pasword get from web.config and 
                //string username1 = clsCommon.sapusername;
                //string password = clsCommon.sappassword;
                // here u can usernam and pasword get from appsettings.json 
                string username1 = sapusername;
                string password = sappassword;
                
                var byteArray = Encoding.ASCII.GetBytes(username1 + ":" + password);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                client.DefaultRequestHeaders.Add("X-CSRF-Token", "fetch");
                HttpResponseMessage resp = client.GetAsync(TARGETURL).Result;
                HttpContent content = resp.Content;
                var responseValue = resp.Headers.FirstOrDefault(i => i.Key == "x-csrf-token").Value.FirstOrDefault();

                cookieJar = new CookieContainer();



                token = resp.Headers.FirstOrDefault(i => i.Key == "x-csrf-token").Value.FirstOrDefault();
                var CookieValue = resp.Headers.FirstOrDefault(i => i.Key == "Set-Cookie").Value.LastOrDefault();

                var cookieContainer = new CookieContainer();

                //using (var handler1 = new HttpClientHandler() { CookieContainer = cookieContainer })

                using (var client1 = new HttpClient(handler))
                {
                    client1.BaseAddress = new Uri(TARGETURL);

                    client1.DefaultRequestHeaders.Accept.Clear();

                    client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    client1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(

            "Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", username1, password))));

                    client1.DefaultRequestHeaders.Add("Cookie", CookieValue);
                    client1.DefaultRequestHeaders.Add("X-CSRF-Token", token);

                    client1.DefaultRequestHeaders.Add("ContentType", "application/json");


                    HttpContent inputcontent = new StringContent(json1, Encoding.UTF8, "application/json");
                    HttpResponseMessage response1 = client1.PostAsync(client1.BaseAddress, inputcontent).Result;

                    if (response1.IsSuccessStatusCode)
                    {
                        SAPobj objSAP = new SAPobj();
                        objSAP.message = response1.Content.ReadAsStringAsync().Result;

                        object c1 = new JavaScriptSerializer().DeserializeObject(objSAP.message);

                        string[] multiArray = objSAP.message.Split(new Char[] { ',', '.', '-', '\n', '\t' });

                        //  var test = response1.Content.r.Result;// Result;
                        //    DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(message);
                        dynamic json12 = JsonConvert.DeserializeObject(objSAP.message);

                        bool a = Array.Exists(multiArray, element => element == "MsgType");

                        int index = Array.IndexOf(multiArray, "\"MsgType\":\"E\"");


                        int indexs = Array.IndexOf(multiArray, "\"MsgType\":\"S\"");

                        if (index > 0)
                        {
                            objSAP.msgtype = multiArray[index].ToString();

                            objSAP.msgdesc = multiArray[index + 1].ToString();

                            objSAP.msgtype = objSAP.msgtype.Replace("\"", "");

                            string[] msgtypeArray = objSAP.msgtype.Split(new Char[] { ':' });

                            objSAP.showmsg = msgtypeArray[1].ToString();

                            objSAP.msgdesc = objSAP.msgdesc.Replace("\"", "");

                            string[] msgdescArray = objSAP.msgdesc.Split(new Char[] { ':' });

                            objSAP.showmsgdesc = msgdescArray[1].ToString();

                            if (objSAP.showmsg == "E")
                            {
                                // show lable messgae in asp.net page
                                //MessageBox.Show(showmsgdesc);
                                string SAPMsg = objSAP.showmsgdesc;
                                //lblRemarks.Text = SAPMsg;
                                //11-2-2020
                                //btnApproval.Enabled = false;
                            }

                            else if (objSAP.showmsg == "S")
                            {
                                // update vendorinfo table with vendor code
                                objSAP.venderSapcode = objSAP.showmsgdesc;
                                //MessageBox.Show(vendercode);
                                //lblRemarks.Text = "Vendor Register" + objSAP.venderSapcode;
                                //lblRemarks.Text = "Supplier is registered with code " + objSAP.venderSapcode;

                                //25-9-2019
                                string Suppliercode = objSAP.venderSapcode;
                                //SupplierCodeUpdateVMS(Suppliercode);

                                //11-2-2020
                                //btnRegister.Enabled = false;
                                //btnSendback.Enabled = false;
                                //btnApproval.Enabled = false;
                            }

                        }
                        else if (indexs > 0)
                        {

                            objSAP.msgtype = multiArray[indexs].ToString();

                            objSAP.msgdesc = multiArray[indexs + 1].ToString();

                            objSAP.msgtype = objSAP.msgtype.Replace("\"", "");

                            string[] msgtypeArray = objSAP.msgtype.Split(new Char[] { ':' });

                            objSAP.showmsg = msgtypeArray[1].ToString();

                            objSAP.msgdesc = objSAP.msgdesc.Replace("\"", "");

                            string[] msgdescArray = objSAP.msgdesc.Split(new Char[] { ':' });

                            objSAP.showmsgdesc = msgdescArray[1].ToString();

                            if (objSAP.showmsg == "E")
                            {
                                // show lable messgae in asp.net page
                                //MessageBox.Show(showmsgdesc);
                                string SAPMsg = objSAP.showmsgdesc;
                                //lblRemarks.Text = SAPMsg;
                                //11-2-2020
                                //btnApproval.Enabled = false;
                            }

                            else if (objSAP.showmsg == "S")
                            {
                                // update vendorinfo table with vendor code
                                objSAP.venderSapcode = objSAP.showmsgdesc;
                                //MessageBox.Show(vendercode);
                                //lblRemarks.Text = "Vendor Register" + objSAP.venderSapcode;
                                //lblRemarks.Text = "Supplier is registered with code " + objSAP.venderSapcode;

                                //25-9-2019
                                string Suppliercode = objSAP.venderSapcode;
                                //SupplierCodeUpdateVMS(Suppliercode);
                                // call method for mail 

                                //11-2-2020
                                //btnRegister.Enabled = false;
                                //btnSendback.Enabled = false;
                                //btnApproval.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        //lblRemarks.Text = Convert.ToString(response1);
                    }

                }
            }
            catch (Exception ex)
            {
                clsCommon.LogError(ex);
                //Response.Redirect("notfound.aspx", false);
            }
        }

       protected void callSAPAPI(VendorSAP vendorSAP)
        {
            try
            {
                string token = "";


                string json1 = vendorsapjson + "," + "\"CINSet\" : " + TaxExemptionjson + "," + "\"WthTaxAccSet\" : " + withholdingjson + "}";

                clsCommon.jsonStatus(json1.ToString());

                string json = JsonConvert.SerializeObject(json1);

                CookieContainer cookieJar = new CookieContainer();

                //here u can call api , api link will be mentioned in web.config

                //var TARGETURL = clsCommon.Sapapiurl;
                //here u can call api , api link will be mentioned in appsettings
                var TARGETURL = Sapapiurl;



                Console.WriteLine("GET: + " + TARGETURL);

                var handler = new HttpClientHandler();


                // here u can usernam and pasword get from web.config and 
                //string username1 = clsCommon.sapusername;
                //string password = clsCommon.sappassword;

                // here u can usernam and pasword get from appsettings.json 
                string username1 = sapusername;
                string password = sappassword;

              
                var byteArray = Encoding.ASCII.GetBytes(username1 + ":" + password);


                var client = new HttpClient(handler);

                client.BaseAddress = new Uri(TARGETURL);
                client.DefaultRequestHeaders.Add(
                    "Authorization",
                    "Basic" + " " + Convert.ToBase64String(byteArray));
                client.DefaultRequestHeaders.Accept.Add(

                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add(
                 "X-CSRF-Token", "fetch");

                client.DefaultRequestHeaders.Add(
                    "User-Agent",
                    "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");



                HttpResponseMessage response = client.GetAsync(TARGETURL).Result;
                HttpContent content = response.Content;
                string testres = response.ToString();

                var responseValue = response.Headers.FirstOrDefault(i => i.Key == "x-csrf-token").Value.FirstOrDefault();

                cookieJar = new CookieContainer();



                token = response.Headers.FirstOrDefault(i => i.Key == "x-csrf-token").Value.FirstOrDefault();

                var CookieValue = response.Headers.FirstOrDefault(i => i.Key == "Set-Cookie").Value.LastOrDefault();

                var cookieContainer = new CookieContainer();

                //using (var handler1 = new HttpClientHandler() { CookieContainer = cookieContainer })

                //using (var client1 = new HttpClient(handler))

                //{

                //    //client1.BaseAddress = new Uri("http://HNJSAPDEV03.tatatechnologies.com:8005/sap/opu/odata/sap/ZODGLVMS001_SRV/VendorDetailsSet");

                //    client1.BaseAddress = new Uri(TARGETURL);

                //    client1.DefaultRequestHeaders.Accept.Clear();

                //    client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //    //       client1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(

                //    //"Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", "nss915470", "Atm@9563"))));

                //    //        client1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(

                //    //"Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", username1, password))));
                //    client1.DefaultRequestHeaders.Add("Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", username1, password))));

                //    // client1.DefaultRequestHeaders.Add("Cookie", CookieValue);
                //    client1.DefaultRequestHeaders.Add("Cookie", CookieValue);
                //    client1.DefaultRequestHeaders.Add("X-CSRF-Token", token);

                //    client1.DefaultRequestHeaders.Add("ContentType", "application/json");

                //    client1.DefaultRequestHeaders.Add(
                //    "User-Agent",
                //    "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                var baseAddress = new Uri(TARGETURL);
                using (var clientnew = new HttpClient(handler) { BaseAddress = baseAddress })
                {
                    var uriBuilder = new UriBuilder(TARGETURL, TARGETURL);

                    clientnew.DefaultRequestHeaders.Accept.Clear();
                    clientnew.DefaultRequestHeaders.Add(
                        "Authorization",
                        "Basic" + " " + Convert.ToBase64String(byteArray));
                    clientnew.DefaultRequestHeaders.Accept.Add(

                        new MediaTypeWithQualityHeaderValue("application/json"));
                    clientnew.DefaultRequestHeaders.Add(
                     "X-CSRF-Token", token);
                    clientnew.DefaultRequestHeaders.Add("Cookie", CookieValue);

                    clientnew.DefaultRequestHeaders.Add(
                        "User-Agent",
                        "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    HttpContent inputcontent = new StringContent(json1, Encoding.UTF8, "application/json");
                    HttpResponseMessage response1 = clientnew.PostAsync(clientnew.BaseAddress, inputcontent).Result;
                    //HttpResponseMessage response = client.PostAsync(client.BaseAddress, inputcontent).ConfigureAwait(continueOnCapturedContext: false);


                    if (response1.IsSuccessStatusCode)
                    {

                        SAPobj objSAP = new SAPobj();
                        objSAP.message = response1.Content.ReadAsStringAsync().Result;

                        object c1 = new JavaScriptSerializer().DeserializeObject(objSAP.message);

                        string[] multiArray = objSAP.message.Split(new Char[] { ',', '.', '-', '\n', '\t' });

                        //  var test = response1.Content.r.Result;// Result;
                        //    DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(message);
                        dynamic json12 = JsonConvert.DeserializeObject(objSAP.message);

                        bool a = Array.Exists(multiArray, element => element == "MsgType");

                        int index = Array.IndexOf(multiArray, "\"MsgType\":\"E\"");


                        int indexs = Array.IndexOf(multiArray, "\"MsgType\":\"S\"");

                        if (index > 0)
                        {
                            objSAP.msgtype = multiArray[index].ToString();

                            objSAP.msgdesc = multiArray[index + 1].ToString();

                            objSAP.msgtype = objSAP.msgtype.Replace("\"", "");

                            string[] msgtypeArray = objSAP.msgtype.Split(new Char[] { ':' });

                            objSAP.showmsg = msgtypeArray[1].ToString();

                            objSAP.msgdesc = objSAP.msgdesc.Replace("\"", "");

                            string[] msgdescArray = objSAP.msgdesc.Split(new Char[] { ':' });

                            objSAP.showmsgdesc = msgdescArray[1].ToString();

                            if (objSAP.showmsg == "E")
                            {
                                // show lable messgae in asp.net page
                                //MessageBox.Show(showmsgdesc);
                                string SAPMsg = objSAP.showmsgdesc;
                                //lblRemarks.Text = SAPMsg;
                            }

                            else if (objSAP.showmsg == "S")
                            {
                                // update vendorinfo table with vendor code
                                objSAP.venderSapcode = objSAP.showmsgdesc;
                                //MessageBox.Show(vendercode);
                                //lblRemarks.Text = "Vendor Register" + objSAP.venderSapcode;
                                //lblRemarks.Text = "Supplier is registered with code " + objSAP.venderSapcode;

                                //25-9-2019
                                string Suppliercode = objSAP.venderSapcode;
                                //SupplierCodeUpdateVMS(Suppliercode);
                            }

                        }
                        else if (indexs > 0)
                        {

                            objSAP.msgtype = multiArray[indexs].ToString();

                            objSAP.msgdesc = multiArray[indexs + 1].ToString();

                            objSAP.msgtype = objSAP.msgtype.Replace("\"", "");

                            string[] msgtypeArray = objSAP.msgtype.Split(new Char[] { ':' });

                            objSAP.showmsg = msgtypeArray[1].ToString();

                            objSAP.msgdesc = objSAP.msgdesc.Replace("\"", "");

                            string[] msgdescArray = objSAP.msgdesc.Split(new Char[] { ':' });

                            objSAP.showmsgdesc = msgdescArray[1].ToString();

                            if (objSAP.showmsg == "E")
                            {
                                // show lable messgae in asp.net page
                                //MessageBox.Show(showmsgdesc);
                                string SAPMsg = objSAP.showmsgdesc;
                                //lblRemarks.Text = SAPMsg;
                            }

                            else if (objSAP.showmsg == "S")
                            {
                                // update vendorinfo table with vendor code
                                objSAP.venderSapcode = objSAP.showmsgdesc;
                                //MessageBox.Show(vendercode);
                                //lblRemarks.Text = "Vendor Register" + objSAP.venderSapcode;
                                //lblRemarks.Text = "Supplier is registered with code " + objSAP.venderSapcode;

                                //25-9-2019
                                string Suppliercode = objSAP.venderSapcode;
                                //SupplierCodeUpdateVMS(Suppliercode);
                                // call method for mail 
                            }
                        }
                    }
                    else
                    {
                        //string JsonhitMsg = response + Convert.ToString(client1.BaseAddress) + token + response1.IsSuccessStatusCode;
                        //lblRemarks.Text = JsonhitMsg;
                        //string JsonhitMsg = token + response1.IsSuccessStatusCode;
                        //lblRemarks.Text = JsonhitMsg;
                        //lblRemarks.Text = Convert.ToString(response1);
                        //Response.Redirect("~/index.html", false);
                    }
                }
            }
            catch (Exception ex)
            {
                clsCommon.LogError(ex);

                
            }
        }

        // PUT api/<RegisterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegisterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
