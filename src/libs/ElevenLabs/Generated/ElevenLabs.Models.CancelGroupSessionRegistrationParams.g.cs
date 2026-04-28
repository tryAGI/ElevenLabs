
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Cancel a single client's registration for a group session.
    /// </summary>
    public sealed partial class CancelGroupSessionRegistrationParams
    {
        /// <summary>
        /// Default Value: cancel_group_session_registration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelGroupSessionRegistrationParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: cancel_group_session_registration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelGroupSessionRegistrationParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelGroupSessionRegistrationParams" /> class.
        /// </summary>
        public CancelGroupSessionRegistrationParams()
        {
        }
    }
}