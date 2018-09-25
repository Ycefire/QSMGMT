using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QSMGMT.QS_Classes
{
    public class SystemRule
    {
        public SystemRule()
        {
        }

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("createdDate")]
        public DateTime createdDate { get; set; }

        [JsonProperty("modifiedDate")]
        public DateTime modifiedDate { get; set; }

        [JsonProperty("modifiedByUserName")]
        public string modifiedByUserName { get; set; }

        [JsonProperty("category")]
        public string category { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("rule")]
        public string rule { get; set; }

        [JsonProperty("resourceFilter")]
        public string resourceFilter { get; set; }

        [JsonProperty("actions")]
        public long actions { get; set; }

        [JsonProperty("comment")]
        public string comment { get; set; }

        [JsonProperty("disabled")]
        public bool disabled { get; set; }

        [JsonProperty("ruleContext")]
        public RuleContext RuleContext { get; set; }

        [JsonProperty("seedId")]
        public string seedId { get; set; }

        [JsonProperty("version")]
        public int version { get; set; }

        [JsonProperty("tags")]
        public IList<object> tags { get; set; }

        [JsonProperty("privileges")]
        public object privileges { get; set; }

        [JsonProperty("schemaPath")]
        public string schemaPath { get; set; }

    }
}
