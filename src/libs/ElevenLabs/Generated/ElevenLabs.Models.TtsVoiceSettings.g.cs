
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Overrides for the voice's saved settings, applied to one generation.
    /// </summary>
    public sealed partial class TtsVoiceSettings
    {
        /// <summary>
        /// How consistent the voice stays across generations. Lower values give more expressive, varied speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// How closely the output adheres to the original voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_boost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// How strongly the speaking style is exaggerated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public double? Style { get; set; }

        /// <summary>
        /// Whether to boost similarity to the original speaker, at some latency cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_speaker_boost")]
        public bool? UseSpeakerBoost { get; set; }

        /// <summary>
        /// The speed of the generated speech, where 1.0 is the voice's natural pace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsVoiceSettings" /> class.
        /// </summary>
        /// <param name="stability">
        /// How consistent the voice stays across generations. Lower values give more expressive, varied speech.
        /// </param>
        /// <param name="similarityBoost">
        /// How closely the output adheres to the original voice.
        /// </param>
        /// <param name="style">
        /// How strongly the speaking style is exaggerated.
        /// </param>
        /// <param name="useSpeakerBoost">
        /// Whether to boost similarity to the original speaker, at some latency cost.
        /// </param>
        /// <param name="speed">
        /// The speed of the generated speech, where 1.0 is the voice's natural pace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsVoiceSettings(
            double? stability,
            double? similarityBoost,
            double? style,
            bool? useSpeakerBoost,
            double? speed)
        {
            this.Stability = stability;
            this.SimilarityBoost = similarityBoost;
            this.Style = style;
            this.UseSpeakerBoost = useSpeakerBoost;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsVoiceSettings" /> class.
        /// </summary>
        public TtsVoiceSettings()
        {
        }

    }
}