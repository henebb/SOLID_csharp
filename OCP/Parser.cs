using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCP.CommandHandlers;
using OCP.Processors;

namespace OCP
{
    public class Parser
    {
        private Dictionary<char, IProcessor> _actionsDictionary;

        public IProcessor DefaultProcessor;

        public void AddProcessor(char controlChar, IProcessor processor)
        {
            if (_actionsDictionary == null)
            {
                _actionsDictionary = new Dictionary<char, IProcessor>();
            }
            _actionsDictionary.Add(controlChar, processor);
        }

        public void Parse(string scriptTextToProcess)
        {
            var reader = new StringReader(scriptTextToProcess);
            var scope = new StringBuilder();

            string line = reader.ReadLine();
            while (line != null)
            {
                var context = new ProcessContext(_actions, line, scope); 
                if (!_actionsDictionary.ContainsKey(line[0]))
                {
                    DefaultProcessor?.Process(context);
                }
                else
                {
                    _actionsDictionary[line[0]].Process(context);
                }

                line = reader.ReadLine();
            }
        }

        private readonly StringBuilder _actions = new StringBuilder();

        public override string ToString()
        {
            if (_actions.Length == 0)
            {
                return nameof(Parser);
            }
            return _actions.ToString();
        }
    }
}
