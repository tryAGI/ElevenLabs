
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Parameters for ElevenLabs TTS models. Charged via TTS billing, not content-generation credits.
    /// </summary>
    public sealed partial class ElevenLabsTTSParameters
    {
        /// <summary>
        /// ID of the voice to use for speech synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// BCP-47 language code for multilingual models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Default Value: mp3_44100_128
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_locators")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryLocator>? PronunciationDictionaryLocators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desired_duration_seconds")]
        public double? DesiredDurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsTTSParameters" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// ID of the voice to use for speech synthesis.
        /// </param>
        /// <param name="languageCode">
        /// BCP-47 language code for multilingual models.
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// Default Value: []
        /// </param>
        /// <param name="desiredDurationSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenLabsTTSParameters(
            string voiceId,
            string? languageCode,
            string? outputFormat,
            global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryLocator>? pronunciationDictionaryLocators,
            double? desiredDurationSeconds)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.LanguageCode = languageCode;
            this.OutputFormat = outputFormat;
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators;
            this.DesiredDurationSeconds = desiredDurationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsTTSParameters" /> class.
        /// </summary>
        public ElevenLabsTTSParameters()
        {
        }
    }
}