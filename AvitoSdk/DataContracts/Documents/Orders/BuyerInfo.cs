using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AvitoSdk.DataContracts.Documents.Orders
{
    [DataContract]
    public class BuyerInfo
    {
        [DataMember(Name = "fullName")]
        public string FullName { get; set; }

        [DataMember(Name = "phoneNumber")]
        public long PhoneNumber { get; set; }
    }
}
