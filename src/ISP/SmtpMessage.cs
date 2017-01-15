using System.Collections.Generic;

namespace ISP
{
    public class SmtpMessage : IMailMessage
    {
        public IList<string> ToAddresses { get; set; }
        public IList<string> BccAddresses { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public void Send()
        {
            // Send
        }
    }
}