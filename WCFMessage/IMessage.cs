using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFMessage
{
    public interface IMessage
    {
        Guid Identity { get; set; }
        string MessageBody { get; set; }
        DateTime DT { get; set; }
    }
}
