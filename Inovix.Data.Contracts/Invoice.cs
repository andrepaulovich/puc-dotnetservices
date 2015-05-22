using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Inovix.Data.Contracts
{
    [DataContract]
    public class Invoice
    {
        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public int Month { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public DateTime? PaymentDate { get; set; }
    }
}
