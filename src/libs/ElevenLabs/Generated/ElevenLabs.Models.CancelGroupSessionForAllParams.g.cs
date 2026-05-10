
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Cancel an entire group session and notify every registered participant.<br/>
    /// Destructive -- prefer ``cancel_group_session_registration`` for cancelling<br/>
    /// a single attendee.
    /// </summary>
    public sealed partial class CancelGroupSessionForAllParams
    {
        /// <summary>
        /// Default Value: cancel_group_session_for_all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelGroupSessionForAllParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: cancel_group_session_for_all
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelGroupSessionForAllParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelGroupSessionForAllParams" /> class.
        /// </summary>
        public CancelGroupSessionForAllParams()
        {
        }

    }
}