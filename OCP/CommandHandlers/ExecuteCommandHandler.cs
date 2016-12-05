using System.Text;
using OCP.Processors;

namespace OCP.CommandHandlers
{
    public class ExecuteCommandHandler : ICommandHandler
    {
        public void Handle(ProcessContext context)
        {
            context.Actions.AppendLine($"ExecuteScope,scope:{context.Scope}");
        }
    }
}