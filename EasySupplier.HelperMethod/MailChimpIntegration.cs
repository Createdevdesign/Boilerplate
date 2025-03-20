using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using MailChimp.Net.Models;
//using Newtonsoft.Json;
//using MailChimp.Types;

namespace BoilerSupplier.HelperMethod
{
    public class MailChimpIntegration
    {
        public void SendMandrillMail(MailChimpEmailTemplates template, string defaultEmailId, string studentName, string instituteName, string emailId, string content, string subject, Dictionary<string, string> parameters = null)
        {
            content = "<div style='font-family:calibri'>" + content + "</div>";
            string Key = ConfigurationHelper.GetFileConfigurationValue("MandrillApiKey");
            //MailChimp.MandrillApi manDrill = new MailChimp.MandrillApi(Key);
            //Mandrill.Messages.Message message = new Mandrill.Messages.Message();
            //message.To = new Mandrill.Messages.Recipient[] { new Mandrill.Messages.Recipient(emailId, studentName) };
            //message.AutoHtml = true;
            //message.FromEmail = defaultEmailId;
            //message.FromName = instituteName;
            //message.Subject = subject;
            //message.TrackClicks = true;
            //message.InlineCss = true;
            //message.Important = true;
            //message.Html = content;
            //manDrill.Send(message, true);
        }
    }
}
