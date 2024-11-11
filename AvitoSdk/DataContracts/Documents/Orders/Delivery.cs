using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AvitoSdk.DataContracts.Documents.Orders
{
    [DataContract]
    public class Delivery
    {
        [DataMember(Name = "buyerInfo")]
        public BuyerInfo BuyerInfo { get; set; }

        [DataMember(Name = "courierInfo")]
        public CourierInfo CourierInfo { get; set; }

        [DataMember(Name = "dispatchNumber")]
        public string DispatchNumber { get; set; }

        [DataMember(Name = "serviceName")]
        public string ServiceName { get; set; }

        [DataMember(Name = "serviceType")]
        public string ServiceType { get; set; }

        [DataMember(Name = "terminalInfo")]
        public TerminalInfo TerminalInfo { get; set; }

        [DataMember(Name = "trackingNumber")]
        public string TrackingNumber { get; set; }
    }
}
