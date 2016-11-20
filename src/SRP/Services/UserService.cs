using System.Collections.Generic;
using MailKit;
using SOLID_csharp.Exceptions;
using SOLID_csharp.Interfaces;
using SOLID_csharp.Models;

namespace SOLID_csharp.Services
{
    public class UserService
    {
        private readonly IEmailService _emailService;
        private readonly IAmTheDataBase _database;

        public UserService(IEmailService emailService, IAmTheDataBase database)
        {
            _emailService = emailService;
            _database = database;
        }

        public void Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
            {
                return;
            }

            var user = new User(email, password);
            _database.Save(user);

            _emailService.SendMail(email);
        }
    }
}
