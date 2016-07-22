using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFMessage;

namespace WcfService
{
    public class WCFService : IWcfService
    {
        public Message GetData(Message incomingMessage)
        {
            return new Message { Identity = incomingMessage.Identity, MessageBody = "Message has been received", DT = DateTime.Now };
        }

        public Message GetPing(Message incomingMessage)
        {
            return new Message { Identity = incomingMessage.Identity, MessageBody = "ping", DT = DateTime.Now };
        }
    }
}
