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
    [ServiceContract]
    public interface IWcfService
    {
        [OperationContract]
        Message GetData(Message value);
        [OperationContract]
        Message GetPing(Message value);
    }
}
