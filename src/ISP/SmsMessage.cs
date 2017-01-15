using System;
using System.Collections.Generic;

namespace ISP
{
    public class SmsMessage : IMessage
    {
        public void Send(IList<string> toAddresses, string body)
        {
            // Send
        }
    }
}