using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AvitoSdk.DataContracts.Documents.Orders
{
    [DataContract]
    public class AvailableAction
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "required")]
        public bool Required { get; set; }
    }
}
