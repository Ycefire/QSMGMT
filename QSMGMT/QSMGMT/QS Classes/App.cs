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
    public class App
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

        [JsonProperty("owner")]
        public User Owner { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("sourceAppId")]
        public Guid SourceAppId { get; set; }

        [JsonProperty("targetAppId")]
        public Guid TargetAppId { get; set; }

        [JsonProperty("publishTime")]
        public DateTimeOffset PublishTime { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("stream")]
        public QsStream Stream { get; set; }

        [JsonProperty("fileSize")]
        public long FileSize { get; set; }

        [JsonProperty("lastReloadTime")]
        public DateTimeOffset LastReloadTime { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("savedInProductVersion")]
        public string SavedInProductVersion { get; set; }

        [JsonProperty("migrationHash")]
        public string MigrationHash { get; set; }

        [JsonProperty("dynamicColor")]
        public string DynamicColor { get; set; }

        [JsonProperty("availabilityStatus")]
        public AppAvailabilityStatus AvailabilityStatus { get; set; }

        [JsonProperty("privileges")]
        public object Privileges { get; set; }

        [JsonProperty("schemaPath")]
        public string SchemaPath { get; set; }
    }

}
