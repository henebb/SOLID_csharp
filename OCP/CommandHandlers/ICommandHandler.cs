using System.Text;
using OCP.Processors;

namespace OCP.CommandHandlers
{
    public interface ICommandHandler
    {
        void Handle(ProcessContext context);
    }
}