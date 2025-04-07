
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchCallStatusResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BatchCallStatusResponseModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.BatchCallStatusResponseModelStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statistics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.BatchCallStatisticsResponseModel Statistics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallStatusResponseModel" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="statistics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchCallStatusResponseModel(
            global::ElevenLabs.BatchCallStatusResponseModelStatus status,
            global::ElevenLabs.BatchCallStatisticsResponseModel statistics)
        {
            this.Status = status;
            this.Statistics = statistics ?? throw new global::System.ArgumentNullException(nameof(statistics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallStatusResponseModel" /> class.
        /// </summary>
        public BatchCallStatusResponseModel()
        {
        }
    }
}