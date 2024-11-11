using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AvitoSdk.DataContracts.Documents.Orders
{
    [DataContract]
    public class Schedules
    {
        [DataMember(Name = "confirmTill")]
        public DateTime ConfirmTill { get; set; }

        [DataMember(Name = "deliveryDate")]
        public DateTime DeliveryDate { get; set; }

        [DataMember(Name = "deliveryDateMa")]
        public DateTime DeliveryDateMa { get; set; }

        [DataMember(Name = "deliveryDateMin")]
        public DateTime DeliveryDateMin { get; set; }

        [DataMember(Name = "setTermsTill")]
        public DateTime SetTermsTill { get; set; }

        [DataMember(Name = "setTrackingNumberTill")]
        public DateTime SetTrackingNumberTill { get; set; }

        [DataMember(Name = "shipTill")]
        public DateTime ShipTill { get; set; }
    }
}
