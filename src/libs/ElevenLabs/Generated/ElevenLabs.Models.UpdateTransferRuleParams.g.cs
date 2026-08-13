
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTransferRuleParams
    {
        /// <summary>
        /// Default Value: update_transfer_rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Whether to offer the post_dial_digits parameter, set from the receptionists' enable_play_keypad_touch_tone_tool config. Digits saved while that is off are dropped when the receptionist is built, so the parameter is hidden rather than accepted and ignored.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_dial_digits_enabled")]
        public bool? PostDialDigitsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTransferRuleParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: update_transfer_rule
        /// </param>
        /// <param name="postDialDigitsEnabled">
        /// Whether to offer the post_dial_digits parameter, set from the receptionists' enable_play_keypad_touch_tone_tool config. Digits saved while that is off are dropped when the receptionist is built, so the parameter is hidden rather than accepted and ignored.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTransferRuleParams(
            string? smbToolType,
            bool? postDialDigitsEnabled)
        {
            this.SmbToolType = smbToolType;
            this.PostDialDigitsEnabled = postDialDigitsEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTransferRuleParams" /> class.
        /// </summary>
        public UpdateTransferRuleParams()
        {
        }

    }
}