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

    public class ReloadTask
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

        [JsonProperty("app")]
        public App App { get; set; }

        [JsonProperty("isManuallyTriggered")]
        public bool IsManuallyTriggered { get; set; }

        [JsonProperty("operational")]
        public Operational Operational { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("taskType")]
        public ReloadTaskType TaskType { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("taskSessionTimeout")]
        public long TaskSessionTimeout { get; set; }

        [JsonProperty("maxRetries")]
        public long MaxRetries { get; set; }

        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        [JsonProperty("privileges")]
        public object Privileges { get; set; }

        [JsonProperty("schemaPath")]
        public string SchemaPath { get; set; }
    }


    public class Operational
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("lastExecutionResult")]
        public LastExecutionResult LastExecutionResult { get; set; }

        [JsonProperty("nextExecution")]
        public DateTimeOffset NextExecution { get; set; }

        [JsonProperty("privileges")]
        public object Privileges { get; set; }
    }

    public class LastExecutionResult
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("executingNodeName")]
        public string ExecutingNodeName { get; set; }

        [JsonProperty("status")]
        public ReloadTaskStatus Status { get; set; }

        [JsonProperty("startTime")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("stopTime")]
        public DateTimeOffset StopTime { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("fileReferenceID")]
        public Guid FileReferenceId { get; set; }

        [JsonProperty("scriptLogAvailable")]
        public bool ScriptLogAvailable { get; set; }

        [JsonProperty("details")]
        public ReloadTaskDetail[] Details { get; set; }

        [JsonProperty("privileges")]
        public object Privileges { get; set; }
    }

    public class ReloadTaskDetail
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("detailsType")]
        public DetailsType DetailsType { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
        
        [JsonProperty("detailCreatedDate")]
        public DateTimeOffset DetailCreatedDate { get; set; }

        [JsonProperty("privileges")]
        public object Privileges { get; set; }
    }

    //public partial class ReloadTask
    //{
    //    public static ReloadTask FromJson(string json) => JsonConvert.DeserializeObject<ReloadTask>(json, QuickType.Converter.Settings);
    //}

    //public static class Serialize
    //{
    //    public static string ToJson(this ReloadTask self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    //}

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters = {
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}
}

