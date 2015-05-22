using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Inovix.Data.Contracts
{
    [DataContract]
    public class CustomerFinance
    {

        [DataMember]
        public bool Active { get; set; }

        [DataMember]
        public IEnumerable<Invoice> Invoices { get; set; }

    }
}
