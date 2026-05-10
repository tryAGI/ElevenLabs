
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Register a client for a scheduled group session.
    /// </summary>
    public sealed partial class RegisterForGroupSessionParams
    {
        /// <summary>
        /// Default Value: register_for_group_session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterForGroupSessionParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: register_for_group_session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterForGroupSessionParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterForGroupSessionParams" /> class.
        /// </summary>
        public RegisterForGroupSessionParams()
        {
        }

    }
}