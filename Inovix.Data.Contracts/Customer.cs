using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Inovix.Data.Contracts
{
    [DataContract]
    public class Customer
    {

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public DateTime BornDate { get; set; }

        [DataMember]
        public string Document { get; set; }

    }
}
