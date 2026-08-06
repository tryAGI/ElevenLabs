
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateDubbingProjectV1DubbingProjectPost
    {
        /// <summary>
        /// The source media file to dub. Provide this or source_url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// The source media file to dub. Provide this or source_url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Public URL to fetch the source media from. Provide this or file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Optional free-form string (max 500 characters) to identify the project on your end.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        public string? Reference { get; set; }

        /// <summary>
        /// BCP-47 language tag of the source media; must be a language the transcription model supports. Any region or script subtag is ignored, since transcription is per-language. Omit to auto-detect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        public string? SourceLanguage { get; set; }

        /// <summary>
        /// Default dubbing model id ('dubbing_v1' or 'dubbing_v2') for the project's language targets; a target may override it. Omit to use the system default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string, object>))]
        public global::ElevenLabs.AnyOf<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string, object>? ModelId { get; set; }

        /// <summary>
        /// Key terms to bias transcription/translation toward (e.g. product or brand names). At most 1000 terms; each term at most 50 characters and 5 words; the characters `&lt;&gt;{}[]\` are not allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// Ids of workspace webhooks to notify when this project becomes ready or fails, and when any of its languages completes or fails. At most 3; each must be a webhook configured in your workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_ids")]
        public global::System.Collections.Generic.IList<string>? WebhookIds { get; set; }

        /// <summary>
        /// Optional shortcut: also create a language target in this BCP-47 language, queued to start once the project is ready. Must be a language the dubbing model supports, and a region-qualified tag must be one of the supported dialects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        public string? TargetLanguage { get; set; }

        /// <summary>
        /// Optional JSON transcript to use instead of automatic transcription. When provided, source_language is required. Segments may include an optional external_id and an optional translation; if any segment includes a translation, target_language is required and every segment must include one (used to seed the target created via target_language).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public byte[]? Transcript { get; set; }

        /// <summary>
        /// Optional JSON transcript to use instead of automatic transcription. When provided, source_language is required. Segments may include an optional external_id and an optional translation; if any segment includes a translation, target_language is required and every segment must include one (used to seed the target created via target_language).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptname")]
        public string? Transcriptname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateDubbingProjectV1DubbingProjectPost" /> class.
        /// </summary>
        /// <param name="file">
        /// The source media file to dub. Provide this or source_url.
        /// </param>
        /// <param name="filename">
        /// The source media file to dub. Provide this or source_url.
        /// </param>
        /// <param name="sourceUrl">
        /// Public URL to fetch the source media from. Provide this or file.
        /// </param>
        /// <param name="reference">
        /// Optional free-form string (max 500 characters) to identify the project on your end.
        /// </param>
        /// <param name="sourceLanguage">
        /// BCP-47 language tag of the source media; must be a language the transcription model supports. Any region or script subtag is ignored, since transcription is per-language. Omit to auto-detect.
        /// </param>
        /// <param name="modelId">
        /// Default dubbing model id ('dubbing_v1' or 'dubbing_v2') for the project's language targets; a target may override it. Omit to use the system default.
        /// </param>
        /// <param name="keyterms">
        /// Key terms to bias transcription/translation toward (e.g. product or brand names). At most 1000 terms; each term at most 50 characters and 5 words; the characters `&lt;&gt;{}[]\` are not allowed.
        /// </param>
        /// <param name="webhookIds">
        /// Ids of workspace webhooks to notify when this project becomes ready or fails, and when any of its languages completes or fails. At most 3; each must be a webhook configured in your workspace.
        /// </param>
        /// <param name="targetLanguage">
        /// Optional shortcut: also create a language target in this BCP-47 language, queued to start once the project is ready. Must be a language the dubbing model supports, and a region-qualified tag must be one of the supported dialects.
        /// </param>
        /// <param name="transcript">
        /// Optional JSON transcript to use instead of automatic transcription. When provided, source_language is required. Segments may include an optional external_id and an optional translation; if any segment includes a translation, target_language is required and every segment must include one (used to seed the target created via target_language).
        /// </param>
        /// <param name="transcriptname">
        /// Optional JSON transcript to use instead of automatic transcription. When provided, source_language is required. Segments may include an optional external_id and an optional translation; if any segment includes a translation, target_language is required and every segment must include one (used to seed the target created via target_language).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateDubbingProjectV1DubbingProjectPost(
            byte[]? file,
            string? filename,
            string? sourceUrl,
            string? reference,
            string? sourceLanguage,
            global::ElevenLabs.AnyOf<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string, object>? modelId,
            global::System.Collections.Generic.IList<string>? keyterms,
            global::System.Collections.Generic.IList<string>? webhookIds,
            string? targetLanguage,
            byte[]? transcript,
            string? transcriptname)
        {
            this.File = file;
            this.Filename = filename;
            this.SourceUrl = sourceUrl;
            this.Reference = reference;
            this.SourceLanguage = sourceLanguage;
            this.ModelId = modelId;
            this.Keyterms = keyterms;
            this.WebhookIds = webhookIds;
            this.TargetLanguage = targetLanguage;
            this.Transcript = transcript;
            this.Transcriptname = transcriptname;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateDubbingProjectV1DubbingProjectPost" /> class.
        /// </summary>
        public BodyCreateDubbingProjectV1DubbingProjectPost()
        {
        }

    }
}