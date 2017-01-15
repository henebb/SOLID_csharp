using System;
using System.Collections.Generic;

namespace ISP
{
    public class SmsMessage : IMessage
    {
        public IList<string> ToAddresses { get; set; }
        public string Body { get; set; }

        public string Subject { get; set; }

        public void Send()
        {
            // Send.
            // But will not use Subject
        }
    }
}