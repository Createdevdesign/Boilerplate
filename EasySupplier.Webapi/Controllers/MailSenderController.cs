using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using FluentEmail.Core;
//using Microsoft.AspNetCore.Mvc;

namespace BoilerSupplier.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailSenderController : ControllerBase
    {


        //public string SendEmail(string Name, string Email, string Message)
        //{

        //    try
        //    {
        //        // Credentials
        //        var credentials = new NetworkCredential("your-email@gmail.com", "your-password");
        //        // Mail message
        //        var mail = new MailMessage()
        //        {
        //            From = new MailAddress("noreply@codinginfinite.com"),
        //            Subject = "Email Sender App",
        //            Body = Message
        //        };
        //        mail.IsBodyHtml = true;
        //        mail.To.Add(new MailAddress(Email));
        //        // Smtp client
        //        var client = new SmtpClient()
        //        {
        //            Port = 587,
        //            DeliveryMethod = SmtpDeliveryMethod.Network,
        //            UseDefaultCredentials = false,
        //            Host = "smtp.gmail.com",
        //            EnableSsl = true,
        //            Credentials = credentials
        //        };
        //        client.Send(mail);
        //        return "Email Sent Successfully!";
        //    }
        //    catch (System.Exception e)
        //    {
        //        return e.Message;
        //    }

        //}




    }
}

