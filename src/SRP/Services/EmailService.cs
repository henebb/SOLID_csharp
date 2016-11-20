using MailKit;
using MimeKit;
using SOLID_csharp.Exceptions;
using SOLID_csharp.Interfaces;

namespace SOLID_csharp.Services
{
    public class EmailService : IEmailService
    {
        private readonly IMailTransport _mailTransport;

        public EmailService(IMailTransport mailTransport)
        {
            _mailTransport = mailTransport;
        }

        public void SendMail(string email)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("mysite@nowhere.com"));
            message.To.Add(new MailboxAddress(email));
            message.Subject = "Hello World!";
            _mailTransport.Send(message);
        }
        public bool ValidateEmail(string email)
        {
            if (!email.Contains("@"))
            {
                throw new ValidationException("Email is not an email!");
            }
            return true;
        }
    }
}