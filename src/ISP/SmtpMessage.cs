using System.Collections.Generic;

namespace ISP
{
    public class SmtpMessage : IMessage
    {
        public IList<string> ToAddresses { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public void Send()
        {
            // Send
        }
    }
}