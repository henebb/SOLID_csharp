﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Parser
    {
        public void Parse(string scriptTextToProcess)
        {
            var reader = new StringReader(scriptTextToProcess);
            var scope = new StringBuilder();

            string line = reader.ReadLine();
            while (line != null)
            {
                switch (line[0])
                {
                    case '$':
                        // Process the entire "line" as a variable, 
                        // i.e. add it to a collection of KeyValuePair.
                        AddToVariables(line);
                        break;
                    case '!':
                        // Depending of what comes after the '!' character, 
                        // process the entire "scope" and/or the command in "line".
                        if (line == "!execute")
                            ExecuteScope(scope);
                        else if (line.StartsWith("!custom_command"))
                            RunCustomCommand(line, scope);
                        else if (line == "!single_line_directive")
                            ProcessDirective(line);
                        break;
                    default:
                        // No processing directive, i.e. add the "line" 
                        // to the current scope.
                        scope.Append(line);
                        break;
                }

                line = reader.ReadLine();
            }
        }

        private void ProcessDirective(string line)
        {
            _actions.AppendLine($"ProcessDirective,line:{line}");
        }

        private void RunCustomCommand(string line, StringBuilder scope)
        {
            _actions.AppendLine($"RunCustomCommand,line:{line},scope:{scope}");
        }

        private void ExecuteScope(StringBuilder scope)
        {
            _actions.AppendLine($"ExecuteScope,scope:{scope}");
        }

        private void AddToVariables(string line)
        {
            _actions.AppendLine($"AddToVariables,line:{line}");
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
