
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Permanently remove a previously-cancelled group session.<br/>
    /// Group analogue of ``delete_calendar_event``: cancel<br/>
    /// (``cancel_group_session_for_all``) is the soft, history-preserving step;<br/>
    /// this tool is the irreversible follow-up that drops the row from Mongo<br/>
    /// and the staff Google Calendar entirely. The backend rejects the call<br/>
    /// (422) if the session hasn't been cancelled yet, so the only safe path<br/>
    /// is cancel-then-delete.
    /// </summary>
    public sealed partial class DeleteGroupSessionParams
    {
        /// <summary>
        /// Default Value: delete_group_session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGroupSessionParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: delete_group_session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteGroupSessionParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGroupSessionParams" /> class.
        /// </summary>
        public DeleteGroupSessionParams()
        {
        }
    }
}