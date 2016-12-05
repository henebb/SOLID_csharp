using System.Text;
using OCP.CommandHandlers;

namespace OCP.Processors
{
    public interface IProcessor
    {
        void AddCommandHandler(string line, ICommandHandler commandHandler);

        void Process(ProcessContext context);
    }
}