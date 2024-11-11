using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AvitoSdk.DataContracts.Documents.Orders
{
    [DataContract]
    public class ReturnPolicy
    {
        [DataMember(Name = "returnStatus")]
        public string ReturnStatus { get; set; }

        [DataMember(Name = "trackingNumber")]
        public string TrackingNumber { get; set; }
    }

}
