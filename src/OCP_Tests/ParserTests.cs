using System.Text;
using OCP;
using OCP.CommandHandlers;
using OCP.Processors;
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
            var parser = new Parser
            {
                DefaultProcessor = new AppendLineToScopeProcessor {DefaultCommandHandler = new AppendLineToScopeCommandHandler()}
            };

            var dollarProcessor = new DollarProcessor {DefaultCommandHandler = new AddToVariableCommandHandler()};
            parser.AddProcessor('$', dollarProcessor);
            var exclamationProcessor = new ExclamationProcessor();
            exclamationProcessor.AddCommandHandler("!execute", new ExecuteCommandHandler());
            exclamationProcessor.AddCommandHandler("!custom_command", new CustomCommandHandler());
            exclamationProcessor.AddCommandHandler("!single_line_directive", new SingleLineDirectiveCommandHandler());
            parser.AddProcessor('!', exclamationProcessor);
            
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
