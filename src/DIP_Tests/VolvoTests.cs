using System.Threading.Tasks;
using DIP;
using NSubstitute;
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
            var engine = Substitute.For<IAmAnEngine>();
            engine.AccelerateTo(Arg.Any<int>())
                .Returns(Task.FromResult<object>(null))
                .AndDoes(info => { engine.CurrentSpeed = 100; });

            var volvo = new Volvo(engine);
            volvo.StartEngine();

            // Act
            await volvo.SetSpeed(100);

            // Assert
            volvo.GetCurrentSpeed().ShouldBe(100);
        }

        [Fact]
        public async Task SetSpeed_To100WithBigBadV12_SetsSpeedTo100()
        {
            var volvo = new Volvo(new BigBadV12());
            volvo.StartEngine();

            // Act
            await volvo.SetSpeed(100);

            // Assert
            volvo.GetCurrentSpeed().ShouldBe(100);
        }
    }
}
