
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Return the full editable config of a single receptionist, including the<br/>
    /// current ``additional_instructions`` text.<br/>
    /// ``list_customer_facing_agents`` is intentionally lightweight (metadata and a<br/>
    /// truncated greeting preview) and omits ``additional_instructions``. Call this<br/>
    /// tool whenever you need the current full text before calling<br/>
    /// ``update_agent_config`` on ``first_message`` or ``additional_instructions``<br/>
    /// so you can preserve what is already there.<br/>
    /// Also returns the read-only call-handling settings the owner edits in the<br/>
    /// app: ``staff_answers_first`` (whether the staff phone rings before the<br/>
    /// receptionist, the staff phone number, the maximum ring time, the staff<br/>
    /// hours per day with their timezone, and whether those hours cover the<br/>
    /// current time), ``turn_eagerness`` (response speed: eager / normal /<br/>
    /// patient), ``background_voice_detection`` (filter background speech on/off),<br/>
    /// ``tool_call_sound`` (hold sound; null means off) and<br/>
    /// ``enable_play_keypad_touch_tone_tool`` (allow touch tones). Call it to<br/>
    /// answer what any of these are currently set to, or to check the setup when<br/>
    /// the owner says calls are not reaching the staff phone.
    /// </summary>
    public sealed partial class GetAgentConfigParams
    {
        /// <summary>
        /// Default Value: get_agent_config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentConfigParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: get_agent_config
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentConfigParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentConfigParams" /> class.
        /// </summary>
        public GetAgentConfigParams()
        {
        }

    }
}