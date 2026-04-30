
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCalendarEventsParams
    {
        /// <summary>
        /// Default Value: list_calendar_events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_cancelled")]
        public bool? IncludeCancelled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCalendarEventsParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: list_calendar_events
        /// </param>
        /// <param name="includeCancelled">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCalendarEventsParams(
            string? smbToolType,
            bool? includeCancelled)
        {
            this.SmbToolType = smbToolType;
            this.IncludeCancelled = includeCancelled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCalendarEventsParams" /> class.
        /// </summary>
        public ListCalendarEventsParams()
        {
        }
    }
}