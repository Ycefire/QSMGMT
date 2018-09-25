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
    public class CompositeEvent
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("createdDate")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public DateTimeOffset ModifiedDate { get; set; }

        [JsonProperty("modifiedByUserName")]
        public string ModifiedByUserName { get; set; }

        [JsonProperty("timeConstraint")]
        public TimeConstraint TimeConstraint { get; set; }

        [JsonProperty("compositeRules")]
        public CompositeRule[] CompositeRules { get; set; }

        [JsonProperty("operational")]
        public CompositeEventOperational Operational { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("eventType")]
        public long EventType { get; set; }

        [JsonProperty("reloadTask")]
        public ReloadTask ReloadTask { get; set; }

        [JsonProperty("userSyncTask")]
        public object UserSyncTask { get; set; }

        [JsonProperty("externalProgramTask")]
        public object ExternalProgramTask { get; set; }

        [JsonProperty("privileges")]
        public object Privileges { get; set; }

        [JsonProperty("schemaPath")]
        public string SchemaPath { get; set; }
    }

    public class CompositeEventOperational
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("timesTriggered")]
        public long TimesTriggered { get; set; }

        [JsonProperty("privileges")]
        public object Privileges { get; set; }
    }

}
