#region System
using System.Collections.Generic;
using System;
using System.Net.Mail;
#endregion System
using System.Configuration;

namespace BoilerSupplier.HelperMethod
{
    public class EmailHelper
    {
        #region Properties

        #endregion Properties

        #region Public Methods
        public delegate void SendMessage(MailChimpEmailTemplates template, string defaultEmailId, string studentName, string instituteName, string emailId, string content, string subject, Dictionary<string, string> parameters, string instituteMailId, string attachment);

        public static bool SendMail(MailChimpEmailTemplates template, string defaultEmailId, string studentName, string instituteName, string toEmailId, string mailBody, string subject, string mailSignature, string instituteMailId, string attachment)
        {
            try
            {
                SendMessage sendMessage;

                if (Convert.ToBoolean(ConfigurationHelper.GetFileConfigurationValue("UseMailChimpServer")))
                {
                    sendMessage = new SendMessage(SendingMailchimpMail);
                }
                else
                {
                    sendMessage = new SendMessage(SendingElasticmail);
                }

                sendMessage.BeginInvoke(template, defaultEmailId, studentName, instituteName, toEmailId, (mailBody + mailSignature), subject, null, null, attachment, null, instituteMailId);
            }
            catch (Exception ex)
            {
                SystemLogs.LogException(ex);
            }
            return true;
        }
        #endregion Public Methods

        #region Private Methods
        private static void SendingMailchimpMail(MailChimpEmailTemplates template, string defaultEmailId, string studentName, string instituteName, string toEmailId, string mailBody, string subject, Dictionary<string, string> parameters, string instituteMailId, string attachment)
        {
            MailChimpIntegration mailChimp = new MailChimpIntegration();
            mailChimp.SendMandrillMail(MailChimpEmailTemplates.Blank, defaultEmailId, studentName, instituteName, toEmailId, mailBody, subject);
        }

        private static void SendingMail(MailChimpEmailTemplates template, string defaultEmailId, string studentName, string instituteName, string toEmailId, string mailBody, string subject, Dictionary<string, string> parameters, string instituteMailId, string attachment)
        {
            try
            {

                string mailServer = "smtp.gmail.com";
                string fromMail = "cms.nctech@gmail.com";

                string mailUserID = "cms.nctech@gmail.com";
                string mailPassword = "Beedu@061214";

                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient(mailServer);

                mail.From = new System.Net.Mail.MailAddress(fromMail);
                mail.IsBodyHtml = true;
                SmtpServer.Port = 587;





                mail.Priority = MailPriority.High;
                mail.To.Add(toEmailId);
                mail.Subject = subject;
                mail.Body = mailBody;

                if (!string.IsNullOrEmpty(attachment))
                {
                    mail.Attachments.Add((new Attachment(attachment)));
                }


                SmtpServer.Credentials = new System.Net.NetworkCredential(mailUserID, mailPassword);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);



            }
            catch (Exception ex)
            {
                //Common.SystemLogs.LogException(ex);
            }
        }

        private static void SendingMailAmazon(MailChimpEmailTemplates template, string defaultEmailId, string studentName, string instituteName, string toEmailId, string mailBody, string subject, Dictionary<string, string> parameters, string instituteMailId, string attachment)
        {
            try
            {
                const String SMTP_USERNAME = "AKIAIUGO2OH7SMT22SIA";
                const String SMTP_PASSWORD = "YuUZyoQkDgiL6zKrlhm3DMEgfEG9yyaX4sLNFesT";
                const String CONFIGSET = "ConfigSet";
                const String HOST = "email-smtp.us-east-1.amazonaws.com";
                const int PORT = 587;

                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(defaultEmailId, instituteName);
                message.To.Add(new MailAddress(toEmailId));
                message.Subject = subject;
                message.Body = mailBody;
                message.Headers.Add("X-SES-CONFIGURATION-SET", CONFIGSET);

                if (!string.IsNullOrEmpty(attachment))
                {
                    message.Attachments.Add((new Attachment(attachment)));
                }
                SmtpClient client = new SmtpClient(HOST, PORT);

                client.Credentials = new System.Net.NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);
                client.EnableSsl = true;
                client.Send(message);
            }
            catch (Exception ex)
            {
                //Common.SystemLogs.LogException(ex);
            }
        }

        private static void SendingElasticmail(MailChimpEmailTemplates template, string defaultEmailId, string studentName, string instituteName, string toEmailId, string mailBody, string subject, Dictionary<string, string> parameters, string instituteMailId, string attachment)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.elasticemail.com");

                if (string.IsNullOrEmpty(instituteMailId))
                {
                    instituteMailId = "noreply@dellstem.com";
                }

                mail.From = new MailAddress(defaultEmailId);
                mail.Sender = new MailAddress(instituteMailId);
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                mail.To.Add(toEmailId);
                mail.Subject = subject;
                mail.Body = mailBody;
                if (!string.IsNullOrEmpty(attachment))
                {
                    mail.Attachments.Add((new Attachment(attachment)));
                }

                SmtpServer.Port = 2525;

                //SmtpServer.Credentials = new System.Net.NetworkCredential("aaam@dellstem.com", "7ba589-f40e-4a3d-a3f2-4d1d41ac18d9");
                SmtpServer.Credentials = new System.Net.NetworkCredential("goutam@dellstem.com", "Dellstem@2017");

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                //Common.SystemLogs.LogException(ex);
            }
        }

        #endregion Private Methods
    }
}
