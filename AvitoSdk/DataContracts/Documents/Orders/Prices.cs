using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AvitoSdk.DataContracts.Documents.Orders
{
    [DataContract]
    public class Prices
    {
        [DataMember(Name = "commission")]
        public decimal Commission { get; set; }

        [DataMember(Name = "discountSum")]
        public decimal DiscountSum { get; set; }

        [DataMember(Name = "price")]
        public decimal Price { get; set; }

        [DataMember(Name = "total")]
        public decimal Total { get; set; }

        [DataMember(Name = "delivery")]
        public decimal Delivery { get; set; }

        [DataMember(Name = "discount")]
        public decimal Discount { get; set; }
    }
}
