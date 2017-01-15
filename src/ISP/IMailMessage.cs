using System.Collections.Generic;

namespace ISP
{
    public interface IMailMessage : IMessage
    {
        string Subject { get; set; }
        IList<string> BccAddresses { get; set; }
    }
}