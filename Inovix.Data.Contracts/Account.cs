using System;
using System.Runtime.Serialization;

namespace Inovix.Data.Contracts
{
    [DataContract]
    public class Account
    {

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public string PlanName { get; set; }
        
    }
}
