
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Allows the agent to play DTMF tones during a phone call.<br/>
    /// This tool can be used to interact with automated phone systems, such as<br/>
    /// navigating phone menus, entering extensions, or inputting numeric codes.
    /// </summary>
    public sealed partial class PlayDTMFToolConfig
    {
        /// <summary>
        /// Default Value: play_keypad_touch_tone
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        public string? SystemToolType { get; set; }

        /// <summary>
        /// Send DTMF tones as out-of-band RTP events (RFC 4733) instead of in-band audio. Only effective for SIP trunk imported numbers.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_out_of_band_dtmf")]
        public bool? UseOutOfBandDtmf { get; set; }

        /// <summary>
        /// If true, the agent will not generate further speech after playing DTMF tones. This prevents the agent's speech from interfering with IVR systems.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suppress_turn_after_dtmf")]
        public bool? SuppressTurnAfterDtmf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayDTMFToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: play_keypad_touch_tone
        /// </param>
        /// <param name="useOutOfBandDtmf">
        /// Send DTMF tones as out-of-band RTP events (RFC 4733) instead of in-band audio. Only effective for SIP trunk imported numbers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="suppressTurnAfterDtmf">
        /// If true, the agent will not generate further speech after playing DTMF tones. This prevents the agent's speech from interfering with IVR systems.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlayDTMFToolConfig(
            string? systemToolType,
            bool? useOutOfBandDtmf,
            bool? suppressTurnAfterDtmf)
        {
            this.SystemToolType = systemToolType;
            this.UseOutOfBandDtmf = useOutOfBandDtmf;
            this.SuppressTurnAfterDtmf = suppressTurnAfterDtmf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayDTMFToolConfig" /> class.
        /// </summary>
        public PlayDTMFToolConfig()
        {
        }

    }
}