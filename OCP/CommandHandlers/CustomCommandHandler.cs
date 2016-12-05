using System.Text;
using OCP.Processors;

namespace OCP.CommandHandlers
{
    public class CustomCommandHandler : ICommandHandler
    {
        public void Handle(ProcessContext context)
        {
            context.Actions.AppendLine($"RunCustomCommand,line:{context.Line},scope:{context.Scope}");
        }
    }
}