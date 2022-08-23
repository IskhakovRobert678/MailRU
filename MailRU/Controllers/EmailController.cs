using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace MailRU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            _emailService.SendEmail(request);
            return Ok();
        }


        //[HttpPost]
        //public IActionResult SendEmail(string body)
        //{
        //    //var email = new MimeMessage();
        //    //email.From.Add(MailboxAddress.Parse("jorge.reichel21@ethereal.email"));
        //    //email.To.Add(MailboxAddress.Parse("jorge.reichel21@ethereal.email"));
        //    //email.Subject = "Test Email Subject";
        //    //email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

        //    //using var smtp = new SmtpClient();
        //    //smtp.Connect("smtp.ethereal.email", 587, MailKit.Security.SecureSocketOptions.StartTls);
        //    //smtp.Authenticate("jorge.reichel21@ethereal.email", "HtnNS99ma19RGyUnqY");
        //    //smtp.Send(email);
        //    //smtp.Disconnect(true);

        //    //var email = new MimeMessage();
        //    //email.From.Add(MailboxAddress.Parse("igrovoirobert@mail.ru"));
        //    //email.To.Add(MailboxAddress.Parse("igrovoirobert@mail.ru"));
        //    //email.Subject = "Test Email Subject";
        //    //email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

        //    //using var smtp = new SmtpClient();
        //    //smtp.Connect("smtp.mail.ru", 465, MailKit.Security.SecureSocketOptions.StartTls);
        //    //smtp.Authenticate("igrovoirobert@mail.ru", "voron123321");
        //    //smtp.Send(email);
        //    //smtp.Disconnect(true);

        //    return Ok();
        //}
    }
}
