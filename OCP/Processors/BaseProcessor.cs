using System.Collections.Generic;
using System.Text;
using OCP.CommandHandlers;

namespace OCP.Processors
{
    public abstract class BaseProcessor : IProcessor
    {
        public ICommandHandler DefaultCommandHandler;

        private Dictionary<string, ICommandHandler> _commandHandlers;

        public void AddCommandHandler(string line, ICommandHandler commandHandler)
        {
            if (_commandHandlers == null)
            {
                _commandHandlers = new Dictionary<string, ICommandHandler>();
            }
            _commandHandlers.Add(line, commandHandler);
        }

        public void Process(ProcessContext processContext)
        {
            var command = processContext.Line.Split(' ')[0];
            if (_commandHandlers != null &&_commandHandlers.ContainsKey(command))
            {
                _commandHandlers[command].Handle(processContext);
            }
            else
            {
                DefaultCommandHandler?.Handle(processContext);
            }
        }
    }
}