using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Inovix.Data.Contracts
{
    [DataContract]
    public class Portabilidade
    {

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string CustomerDocument { get; set; }

        [DataMember]
        public string Old { get; set; }

        [DataMember]
        public string New { get; set; }

    }
}
