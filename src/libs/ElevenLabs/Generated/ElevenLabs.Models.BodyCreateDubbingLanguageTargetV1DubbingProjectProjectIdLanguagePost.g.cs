
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost
    {
        /// <summary>
        /// BCP-47 language tag to dub the project into (for example, `fr` or `es-MX`). Must be one of the [languages the project's dubbing model supports](https://elevenlabs.io/docs/help-center/product/dubbing/which-languages-are-supported-in-dubbing), and a region-qualified tag must be one of the supported dialects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetLanguage { get; set; }

        /// <summary>
        /// Voice settings applied to every speaker in this language. Omit to use the defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_settings")]
        public global::ElevenLabs.VoiceSettings? VoiceSettings { get; set; }

        /// <summary>
        /// Enterprise only. Optional translations to use instead of machine translation. A map from each source segment's `external_id` (or its `id`, if you supplied none) to the translated text; every source segment must be covered exactly once. At most 20,000 entries, totaling at most 4 MiB of text. See [Bring your own transcript](https://elevenlabs.io/docs/eleven-api/guides/how-to/dubbing/bring-your-own-transcript).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translations")]
        public global::System.Collections.Generic.Dictionary<string, string>? Translations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost" /> class.
        /// </summary>
        /// <param name="targetLanguage">
        /// BCP-47 language tag to dub the project into (for example, `fr` or `es-MX`). Must be one of the [languages the project's dubbing model supports](https://elevenlabs.io/docs/help-center/product/dubbing/which-languages-are-supported-in-dubbing), and a region-qualified tag must be one of the supported dialects.
        /// </param>
        /// <param name="voiceSettings">
        /// Voice settings applied to every speaker in this language. Omit to use the defaults.
        /// </param>
        /// <param name="translations">
        /// Enterprise only. Optional translations to use instead of machine translation. A map from each source segment's `external_id` (or its `id`, if you supplied none) to the translated text; every source segment must be covered exactly once. At most 20,000 entries, totaling at most 4 MiB of text. See [Bring your own transcript](https://elevenlabs.io/docs/eleven-api/guides/how-to/dubbing/bring-your-own-transcript).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost(
            string targetLanguage,
            global::ElevenLabs.VoiceSettings? voiceSettings,
            global::System.Collections.Generic.Dictionary<string, string>? translations)
        {
            this.TargetLanguage = targetLanguage ?? throw new global::System.ArgumentNullException(nameof(targetLanguage));
            this.VoiceSettings = voiceSettings;
            this.Translations = translations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost" /> class.
        /// </summary>
        public BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost()
        {
        }

    }
}