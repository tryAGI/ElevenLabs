
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request body for the ElevenLabs Flash v2.5 TTS model.
    /// </summary>
    public sealed partial class ElevenFlashV25Request
    {
        /// <summary>
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::ElevenLabs.WebhookTarget? Webhook { get; set; }

        /// <summary>
        /// The text to synthesize into speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The ID of the voice to speak with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Voice { get; set; }

        /// <summary>
        /// The audio encoding of the output, as `codec_sampleRateHz_bitrateKbps`. `mp3_44100_192` requires the Creator tier or above.<br/>
        /// Default Value: mp3_44100_128
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ElevenFlashV25RequestOutputFormatJsonConverter))]
        public global::ElevenLabs.ElevenFlashV25RequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Pronunciation dictionaries to apply to the text, in order of precedence. Up to 3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_locators")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocator>? PronunciationDictionaryLocators { get; set; }

        /// <summary>
        /// The model to use for the generation.
        /// </summary>
        /// <default>"eleven_flash_v2_5"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = "eleven_flash_v2_5";

        /// <summary>
        /// ISO 639-1 language code to enforce on the output. Omit to detect the language from the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Overrides for the voice's saved settings, applied to this generation only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_settings")]
        public global::ElevenLabs.ElevenFlashV25VoiceSettings? VoiceSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenFlashV25Request" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to synthesize into speech.
        /// </param>
        /// <param name="voice">
        /// The ID of the voice to speak with.
        /// </param>
        /// <param name="webhook">
        /// Include to send the generation's result to the workspace's configured flows webhooks once it completes or fails. The webhook payload matches the terminal response of the corresponding GET endpoint.
        /// </param>
        /// <param name="outputFormat">
        /// The audio encoding of the output, as `codec_sampleRateHz_bitrateKbps`. `mp3_44100_192` requires the Creator tier or above.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// Pronunciation dictionaries to apply to the text, in order of precedence. Up to 3.
        /// </param>
        /// <param name="languageCode">
        /// ISO 639-1 language code to enforce on the output. Omit to detect the language from the text.
        /// </param>
        /// <param name="voiceSettings">
        /// Overrides for the voice's saved settings, applied to this generation only.
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenFlashV25Request(
            string text,
            string voice,
            global::ElevenLabs.WebhookTarget? webhook,
            global::ElevenLabs.ElevenFlashV25RequestOutputFormat? outputFormat,
            global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocator>? pronunciationDictionaryLocators,
            string? languageCode,
            global::ElevenLabs.ElevenFlashV25VoiceSettings? voiceSettings,
            string modelId = "eleven_flash_v2_5")
        {
            this.Webhook = webhook;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.OutputFormat = outputFormat;
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators;
            this.ModelId = modelId;
            this.LanguageCode = languageCode;
            this.VoiceSettings = voiceSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenFlashV25Request" /> class.
        /// </summary>
        public ElevenFlashV25Request()
        {
        }

    }
}