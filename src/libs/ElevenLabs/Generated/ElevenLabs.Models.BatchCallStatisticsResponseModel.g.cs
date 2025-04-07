
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchCallStatisticsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reported_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReportedAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallStatisticsResponseModel" /> class.
        /// </summary>
        /// <param name="reportedAtUnix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchCallStatisticsResponseModel(
            int reportedAtUnix)
        {
            this.ReportedAtUnix = reportedAtUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallStatisticsResponseModel" /> class.
        /// </summary>
        public BatchCallStatisticsResponseModel()
        {
        }
    }
}