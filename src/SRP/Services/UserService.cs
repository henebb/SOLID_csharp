using MailKit;
using MimeKit;
using SOLID_csharp.Exceptions;
using SOLID_csharp.Interfaces;
using SOLID_csharp.Models;

namespace SOLID_csharp.Services
{
    public class UserService
    {
        private readonly IMailTransport _mailTransport;
        private readonly IAmTheDataBase _database;

        public UserService(IMailTransport mailTransport, IAmTheDataBase database)
        {
            _mailTransport = mailTransport;
            _database = database;
        }

        public void Register(string email, string password)
        {
            if (!email.Contains("@"))
            {
                throw new ValidationException("Email is not an email!");
            }
            var user = new User(email, password);
            _database.Save(user);
            var message = new MimeMessage("mysite@nowhere.com", email) {Subject = "Hello World!"};
            _mailTransport.Send(message);
        }
    }
}
