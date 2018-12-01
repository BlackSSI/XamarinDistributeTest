using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace XamarinDistributeSample.Data
{
    public class MemberListInAzure
    {
        public int Id { get; set; }

        [JsonProperty(PropertyName ="FullName")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "UserId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "UserCounterName")]
        public string UserCounterName { get; set; }

        [JsonProperty(PropertyName = "Team")]
        public string Team { get; set; }
    }
}
