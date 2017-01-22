using System.Threading.Tasks;
using DIP;
using Xunit;
using Shouldly;

namespace DIP_Tests
{
    public class VolvoTests
    {
        [Fact]
        public async Task SetSpeed_To100_SetsSpeedTo100()
        {
            // Arrange
            var volvo = new Volvo();
            volvo.StartEngine();

            // Act
            await volvo.SetSpeed(100);

            // Assert
            volvo.GetCurrentSpeed().ShouldBe(100);
        }
    }
}
