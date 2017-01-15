using System.Collections.Generic;

namespace ISP
{
    public interface IMessage
    {
        void Send(IList<string> toAddresses, string body);
    }
}
