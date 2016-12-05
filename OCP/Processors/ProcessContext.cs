using System.Text;

namespace OCP.Processors
{
    public class ProcessContext
    {
        public StringBuilder Actions { get; set; }
        public string Line { get; set; }
        public StringBuilder Scope { get; set; }

        public ProcessContext(StringBuilder actions, string line, StringBuilder scope)
        {
            Actions = actions;
            Line = line;
            Scope = scope;
        }
    }
}