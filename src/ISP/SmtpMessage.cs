using System.Collections.Generic;

namespace ISP
{
    public class SmtpMessage : IEmailMessage
    {
        public IList<string> BccAddresses { get; set; }
        public string Subject { get; set; }
        public void Send(IList<string> toAddresses, string body)
        {
            // Send
        }
    }
}