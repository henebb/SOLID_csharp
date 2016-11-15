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
        private readonly IMailTransport _mailTransport;

        public UserServiceTests()
        {
            _mailTransport = Substitute.For<IMailTransport>();
            _database = Substitute.For<IAmTheDataBase>();

            _userService = new UserService(_mailTransport, _database);
        }

        [Fact]
        public void Register_InvalidEmail_ThrowsException()
        {
            const string invalidEmail = "invalid";
            const string password = "secret";

            Assert.Throws<ValidationException>(() =>
            {
                _userService.Register(invalidEmail, password);
            });
        }

        [Fact]
        public void Register_ValidEmail_SavesUserAndSendsMail()
        {
            const string validEmail = "valid@email.net";
            const string password = "secret";

            _userService.Register(validEmail, password);

            // Assert
            // Database should save
            _database.Received(1).Save(Arg.Any<User>());
            // Mail should be sent
            _mailTransport.Received(1)
                .Send(Arg.Is<MimeMessage>(message => ((MailboxAddress) message.To[0]).Address == validEmail));
        }
    }
}
