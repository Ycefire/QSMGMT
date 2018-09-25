using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace QSMGMT.QS_Classes
{
    public class User
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("createdDate")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public DateTimeOffset ModifiedDate { get; set; }

        [JsonProperty("modifiedByUserName")]
        public string ModifiedByUserName { get; set; }

        [JsonProperty("customProperties")]
        public object[] CustomProperties { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userDirectory")]
        public string UserDirectory { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roles")]
        public object[] Roles { get; set; }

        [JsonProperty("attributes")]
        public object[] Attributes { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("removedExternally")]
        public bool RemovedExternally { get; set; }

        [JsonProperty("blacklisted")]
        public bool Blacklisted { get; set; }

        [JsonProperty("deleteProhibited")]
        public bool DeleteProhibited { get; set; }

        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        [JsonProperty("privileges")]
        public object Privileges { get; set; }

        [JsonProperty("schemaPath")]
        public string SchemaPath { get; set; }
    }
}
