using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RestAPI.Models
{
    [DataContract]
    public class UserInfo
    {
        [DataMember(Name = "registeredUser")]
        public string RegisteredUser { get; set; }

        [DataMember(Name = "domainItems")]
        public string DomainItems { get; set; }

        [DataMember(Name = "registeredDate")]
        public DateTime RegisteredDate { get; set; }

        [DataMember(Name = "expiredDate")]
        public DateTime ExpiredDate { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}