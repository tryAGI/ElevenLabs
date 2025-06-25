
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PlayDTMFToolConfigSystemToolTypeJsonConverter))]
        public global::ElevenLabs.PlayDTMFToolConfigSystemToolType? SystemToolType { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlayDTMFToolConfig(
            global::ElevenLabs.PlayDTMFToolConfigSystemToolType? systemToolType)
        {
            this.SystemToolType = systemToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayDTMFToolConfig" /> class.
        /// </summary>
        public PlayDTMFToolConfig()
        {
        }
    }
}