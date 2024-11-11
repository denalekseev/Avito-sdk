using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AvitoSdk.DataContracts.Documents
{
    [DataContract]
    public class GetOrdersRequest
    {
        [DataMember(Name = "page")]
        public long? Page { get; set; }

        [DataMember(Name = "limit ")]
        public long? limit { get; set; }
    }
}
