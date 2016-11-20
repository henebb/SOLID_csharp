using MailKit;
using MimeKit;
using NSubstitute;
using SOLID_csharp.Exceptions;
using SOLID_csharp.Interfaces;
using SOLID_csharp.Models;
using SOLID_csharp.Services;
using Xunit;

namespace SRP_Tests
{
    public class UserServiceTests
    {
        private readonly UserService _userService;
        private readonly IAmTheDataBase _database;
        private readonly IEmailService _emailService;

        public UserServiceTests()
        {
            _emailService = Substitute.For<IEmailService>();
            _database = Substitute.For<IAmTheDataBase>();

            _userService = new UserService(_emailService, _database);
        }

        [Fact]
        public void Register_WithEmailAndPassword_SavesUserAndSendsMail()
        {
            const string validEmail = "valid@email.net";
            const string password = "secret";
            _emailService.ValidateEmail(validEmail).Returns(true);

            _userService.Register(validEmail, password);

            // Assert
            // Database should save
            _database.Received(1).Save(Arg.Any<User>());
            // Mail should be sent
            _emailService.Received(1).SendMail(validEmail);
        }
    }
}
