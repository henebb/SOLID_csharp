using OCP.Processors;

namespace OCP.CommandHandlers
{
    public class AppendLineToScopeCommandHandler : ICommandHandler
    {
        public void Handle(ProcessContext context)
        {
            context.Scope.Append(context.Line);
        }
    }
}