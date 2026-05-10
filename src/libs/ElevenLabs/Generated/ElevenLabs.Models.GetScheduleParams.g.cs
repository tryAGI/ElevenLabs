
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetScheduleParams
    {
        /// <summary>
        /// Default Value: get_schedule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_location_filter")]
        public bool? IncludeLocationFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScheduleParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: get_schedule
        /// </param>
        /// <param name="includeLocationFilter">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetScheduleParams(
            string? smbToolType,
            bool? includeLocationFilter)
        {
            this.SmbToolType = smbToolType;
            this.IncludeLocationFilter = includeLocationFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScheduleParams" /> class.
        /// </summary>
        public GetScheduleParams()
        {
        }

    }
}