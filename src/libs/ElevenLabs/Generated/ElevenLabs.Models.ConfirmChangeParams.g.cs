
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The owner's spoken answer to changes the assistant read back to them.<br/>
    /// Runs in the agent runtime rather than Reception: it needs the conversation's<br/>
    /// chat to check the owner actually answered after hearing the changes.
    /// </summary>
    public sealed partial class ConfirmChangeParams
    {
        /// <summary>
        /// Default Value: smb_confirm_change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmChangeParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: smb_confirm_change
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfirmChangeParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmChangeParams" /> class.
        /// </summary>
        public ConfirmChangeParams()
        {
        }

    }
}