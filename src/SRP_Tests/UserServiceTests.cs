using MailKit;
using NSubstitute;
using SOLID_csharp.Interfaces;
using SOLID_csharp.Services;
using Xunit;

namespace SRP_Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void Register_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mailTransport = Substitute.For<IMailTransport>();
            var database = Substitute.For<IAmTheDataBase>();

            var userService = new UserService(mailTransport, database);

            // Act
            const string email = "some@domain.net";
            const string password = "secret";

            userService.Register(email, password);

            // Assert

            // Continue here...
        }
    }
}
