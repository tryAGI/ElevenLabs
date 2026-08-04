
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost
    {
        /// <summary>
        /// BCP-47 language tag to dub the project into (e.g. 'fr', 'es-MX'); must be a language the dubbing model supports. A region-qualified tag must be one of the supported dialects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetLanguage { get; set; }

        /// <summary>
        /// Dubbing model id for this target; omit to use the project default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Voice settings applied to the whole language (e.g. cloning strength).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_settings")]
        public global::ElevenLabs.VoiceSettings? VoiceSettings { get; set; }

        /// <summary>
        /// Optional translations to use instead of machine translation. A map from each source segment's external_id (or its id, if you supplied none) to the translated text; every source segment must be covered exactly once. At most 20000 entries, totalling at most 4 MiB of text.
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
        /// BCP-47 language tag to dub the project into (e.g. 'fr', 'es-MX'); must be a language the dubbing model supports. A region-qualified tag must be one of the supported dialects.
        /// </param>
        /// <param name="modelId">
        /// Dubbing model id for this target; omit to use the project default.
        /// </param>
        /// <param name="voiceSettings">
        /// Voice settings applied to the whole language (e.g. cloning strength).
        /// </param>
        /// <param name="translations">
        /// Optional translations to use instead of machine translation. A map from each source segment's external_id (or its id, if you supplied none) to the translated text; every source segment must be covered exactly once. At most 20000 entries, totalling at most 4 MiB of text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost(
            string targetLanguage,
            string? modelId,
            global::ElevenLabs.VoiceSettings? voiceSettings,
            global::System.Collections.Generic.Dictionary<string, string>? translations)
        {
            this.TargetLanguage = targetLanguage ?? throw new global::System.ArgumentNullException(nameof(targetLanguage));
            this.ModelId = modelId;
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