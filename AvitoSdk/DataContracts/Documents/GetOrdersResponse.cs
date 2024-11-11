using AvitoSdk.DataContracts.Documents.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AvitoSdk.DataContracts.Documents
{
    [DataContract]
    public class GetOrdersResponse
    {
        [DataMember(Name = "hasMore")]
        public bool HasMore { get; set; }

        [DataMember(Name = "orders")]
        public List<Order> Orders { get; set; }        
    }
}
