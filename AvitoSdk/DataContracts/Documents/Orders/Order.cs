using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AvitoSdk.DataContracts.Documents.Orders
{
    [DataContract]
    public class Order
    {
        [DataMember(Name = "createdAt")]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "delivery")]
        public Delivery Delivery { get; set; }

        [DataMember(Name = "items")]
        public List<Item> Items { get; set; }

        [DataMember(Name = "availableActions")]
        public List<AvailableAction> AvailableActions { get; set; }

        [DataMember(Name = "marketplaceId")]
        public string MarketplaceId { get; set; }

        [DataMember(Name = "prices")]
        public Prices Prices { get; set; }

        [DataMember(Name = "schedules ")]
        public Schedules Schedules { get; set; }

        [DataMember(Name = "updatedAt")]
        public DateTime UpdatedAt { get; set; }
       
        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "returnPolicy")]
        public ReturnPolicy ReturnPolicy { get; set; }
    }
}