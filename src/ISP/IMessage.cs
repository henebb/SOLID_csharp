using System.Collections.Generic;

namespace ISP
{
    public interface IMessage
    {
        IList<string> ToAddresses { get; set; }
        string Body { get; set; }
        void Send();
    }
}
