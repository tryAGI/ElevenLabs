
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Schedule a single instance of a group service.<br/>
    /// The session's duration is derived from the parent service so the assistant<br/>
    /// only has to pin start time, the (optional) instructor / room, and the<br/>
    /// location. Participants register separately via<br/>
    /// ``register_for_group_session``.
    /// </summary>
    public sealed partial class ScheduleGroupSessionParams
    {
        /// <summary>
        /// Default Value: schedule_group_session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleGroupSessionParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: schedule_group_session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleGroupSessionParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleGroupSessionParams" /> class.
        /// </summary>
        public ScheduleGroupSessionParams()
        {
        }
    }
}