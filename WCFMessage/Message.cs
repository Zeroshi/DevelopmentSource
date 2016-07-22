using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFMessage
{
    [DataContract]
    public class Message : IMessage
    {
        [DataMember]
        public Guid Identity { get; set; }
        [DataMember]
        public string MessageBody { get; set; }
        [DataMember]
        public DateTime DT { get; set; }
    }
}
