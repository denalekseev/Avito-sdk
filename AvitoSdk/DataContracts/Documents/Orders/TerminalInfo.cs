using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AvitoSdk.DataContracts.Documents.Orders
{
    [DataContract]
    public class TerminalInfo
    {
        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "code")]
        public string Code { get; set; }
    }
}
