using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LSP;
using Shouldly;
using Xunit;

namespace LSP_Tests
{
    public class DuckContestTests
    {
        [Fact]
        public void DuckContest_StartContest_MakesAllDuckSwim()
        {
            // Arrange
            var contest = new DuckContest();
            contest.AddDuck(new OrganicDuck());
            contest.AddDuck(new ElectricDuck());

            // Act
            contest.StartContest();

            // Assert
            var allAreSwimming = contest.Ducks.All(duck => duck.IsSwimming);
            allAreSwimming.ShouldBeTrue();
        }
    }
}
