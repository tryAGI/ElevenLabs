
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Get a summary of key business analytics for a time period.
    /// </summary>
    public sealed partial class GetAnalyticsSummaryParams
    {
        /// <summary>
        /// Default Value: get_analytics_summary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsSummaryParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: get_analytics_summary
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsSummaryParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsSummaryParams" /> class.
        /// </summary>
        public GetAnalyticsSummaryParams()
        {
        }

    }
}