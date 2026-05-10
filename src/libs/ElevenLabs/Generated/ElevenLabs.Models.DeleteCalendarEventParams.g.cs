
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Permanently remove a previously-cancelled calendar event.<br/>
    /// This delete tool is the irreversible follow-up to cancel_calendar_event.<br/>
    /// The backend rejects the call (422) if the event hasn't been<br/>
    /// cancelled yet, so the only safe path is cancel-then-delete.
    /// </summary>
    public sealed partial class DeleteCalendarEventParams
    {
        /// <summary>
        /// Default Value: delete_calendar_event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCalendarEventParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: delete_calendar_event
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteCalendarEventParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCalendarEventParams" /> class.
        /// </summary>
        public DeleteCalendarEventParams()
        {
        }

    }
}