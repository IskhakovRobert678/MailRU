namespace MailRU.Controllers.Services.EmailServices
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
