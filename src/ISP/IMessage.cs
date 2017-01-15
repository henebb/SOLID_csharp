using System.Collections.Generic;

namespace ISP
{
    public interface IMessage
    {
        IList<string> ToAddresses { get; set; }
        // IList<string> BccAddresses { get; set; }
        string Body { get; set; }
        string Subject { get; set; }
        void Send();
    }
}
