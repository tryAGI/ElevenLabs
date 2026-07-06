
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
        /// BCP-47 language tag of the source media. Omit to auto-detect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        public string? SourceLanguage { get; set; }

        /// <summary>
        /// Default dubbing model id for the project's language targets; a target may override it. Omit to use the system default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Key terms to bias transcription/translation toward (e.g. product or brand names). At most 1000 terms; each term at most 50 characters and 5 words; the characters `&lt;&gt;{}[]\` are not allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// Optional shortcut: also create a language target in this BCP-47 language, queued to start once the project is ready.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        public string? TargetLanguage { get; set; }

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
        /// BCP-47 language tag of the source media. Omit to auto-detect.
        /// </param>
        /// <param name="modelId">
        /// Default dubbing model id for the project's language targets; a target may override it. Omit to use the system default.
        /// </param>
        /// <param name="keyterms">
        /// Key terms to bias transcription/translation toward (e.g. product or brand names). At most 1000 terms; each term at most 50 characters and 5 words; the characters `&lt;&gt;{}[]\` are not allowed.
        /// </param>
        /// <param name="targetLanguage">
        /// Optional shortcut: also create a language target in this BCP-47 language, queued to start once the project is ready.
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
            string? modelId,
            global::System.Collections.Generic.IList<string>? keyterms,
            string? targetLanguage)
        {
            this.File = file;
            this.Filename = filename;
            this.SourceUrl = sourceUrl;
            this.Reference = reference;
            this.SourceLanguage = sourceLanguage;
            this.ModelId = modelId;
            this.Keyterms = keyterms;
            this.TargetLanguage = targetLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateDubbingProjectV1DubbingProjectPost" /> class.
        /// </summary>
        public BodyCreateDubbingProjectV1DubbingProjectPost()
        {
        }

    }
}