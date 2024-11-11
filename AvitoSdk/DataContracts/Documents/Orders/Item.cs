using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AvitoSdk.DataContracts.Documents.Orders
{
    [DataContract]
    public class Item
    {
        [DataMember(Name = "avitoId")]
        public string AvitoId { get; set; }

        [DataMember(Name = "chatId")]
        public string ChatId { get; set; }

        [DataMember(Name = "count")]
        public int Count { get; set; }

        [DataMember(Name = "discounts")]
        public List<Discount> Discounts { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "location")]
        public string Location { get; set; }

        [DataMember(Name = "prices")]
        public Prices Prices { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }
    }
}
