
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Overrides for the voice's saved settings, applied to one generation.
    /// </summary>
    public sealed partial class ElevenV3VoiceSettings
    {
        /// <summary>
        /// How consistent the voice stays across generations. Lower values give more expressive, varied speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenV3VoiceSettings" /> class.
        /// </summary>
        /// <param name="stability">
        /// How consistent the voice stays across generations. Lower values give more expressive, varied speech.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenV3VoiceSettings(
            double? stability)
        {
            this.Stability = stability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenV3VoiceSettings" /> class.
        /// </summary>
        public ElevenV3VoiceSettings()
        {
        }

    }
}