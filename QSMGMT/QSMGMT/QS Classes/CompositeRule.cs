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
    public class CompositeRule
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("createdDate")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public DateTimeOffset ModifiedDate { get; set; }

        [JsonProperty("modifiedByUserName")]
        public string ModifiedByUserName { get; set; }

        [JsonProperty("ruleState")]
        public RuleState RuleState { get; set; }

        [JsonProperty("reloadTask")]
        public ReloadTask ReloadTask { get; set; }

        [JsonProperty("userSyncTask")]
        public object UserSyncTask { get; set; }

        [JsonProperty("externalProgramTask")]
        public object ExternalProgramTask { get; set; }

        [JsonProperty("operational")]
        public CompositeRuleOperational Operational { get; set; }

        [JsonProperty("schemaPath")]
        public string SchemaPath { get; set; }
    }

    public class CompositeRuleOperational
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("timeStamp")]
        public DateTimeOffset TimeStamp { get; set; }

        [JsonProperty("currentState")]
        public RuleState CurrentState { get; set; }

        [JsonProperty("privileges")]
        public object Privileges { get; set; }
    }
}
