using OCP;
using Shouldly;
using Xunit;

namespace OCP_Tests
{
    public class ParserTests
    {
        [Fact]
        public void Parse_ScriptText_ProducesResult()
        {
            // Arrange
            const string scriptText = @"$variable
!execute
!custom_command cd..
!single_line_directive
Body content
Paragraph 1
";

            // Act
            var parser = new Parser();
            parser.Parse(scriptText);

            // Assert
            parser.ToString().ShouldBe(@"AddToVariables,line:$variable
ExecuteScope,scope:
RunCustomCommand,line:!custom_command cd..,scope:
ProcessDirective,line:!single_line_directive
");
        }
    }
}
