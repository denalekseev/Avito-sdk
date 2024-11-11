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
        public int Commission { get; set; }

        [DataMember(Name = "discountSum")]
        public int DiscountSum { get; set; }

        [DataMember(Name = "price")]
        public int Price { get; set; }

        [DataMember(Name = "total")]
        public int Total { get; set; }

        [DataMember(Name = "delivery")]
        public int Delivery { get; set; }

        [DataMember(Name = "discount")]
        public int Discount { get; set; }
    }
}
