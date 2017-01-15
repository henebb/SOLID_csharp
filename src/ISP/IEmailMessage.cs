using System.Collections.Generic;

namespace ISP
{
    public interface IEmailMessage : IMessage
    {
        string Subject { get; set; }
        IList<string> BccAddresses { get; set; }
    }
}