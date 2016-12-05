using System.Text;
using OCP.Processors;

namespace OCP.CommandHandlers
{
    public class SingleLineDirectiveCommandHandler : ICommandHandler
    {
        public void Handle(ProcessContext context)
        {
            context.Actions.AppendLine($"ProcessDirective,line:{context.Line}");
        }
    }
}