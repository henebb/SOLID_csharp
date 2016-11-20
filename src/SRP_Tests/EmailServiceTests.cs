using MailKit;
using NSubstitute;
using Shouldly;
using SOLID_csharp.Exceptions;
using SOLID_csharp.Services;
using Xunit;

namespace SRP_Tests
{
    public class EmailServiceTests
    {
        [Fact]
        public void Validate_InvalidEmail_ThrowsException()
        {
            var mailTransport = Substitute.For<IMailTransport>();
            var emailService = new EmailService(mailTransport);

            const string invalidEmail = "invalid";

            Assert.Throws<ValidationException>(() =>
            {
                emailService.ValidateEmail(invalidEmail);
            });
        }

        [Fact]
        public void Validate_ValidEmail_ReturnsTrue()
        {
            var mailTransport = Substitute.For<IMailTransport>();
            var emailService = new EmailService(mailTransport);

            const string invalidEmail = "valid@email.net";

            var result = emailService.ValidateEmail(invalidEmail);

            result.ShouldBeTrue();
        }
    }
}