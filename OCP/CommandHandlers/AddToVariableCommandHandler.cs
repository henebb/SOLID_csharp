using System.Text;
using OCP.Processors;

namespace OCP.CommandHandlers
{
    public class AddToVariableCommandHandler : ICommandHandler
    {
        public void Handle(ProcessContext context)
        {
            context.Actions.AppendLine($"AddToVariables,line:{context.Line}");
        }
    }
}