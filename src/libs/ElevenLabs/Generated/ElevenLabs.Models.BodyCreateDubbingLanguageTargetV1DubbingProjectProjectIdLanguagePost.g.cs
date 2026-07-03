
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost
    {
        /// <summary>
        /// BCP-47 language tag to dub the project into (e.g. 'fr', 'es-419').
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost" /> class.
        /// </summary>
        /// <param name="targetLanguage">
        /// BCP-47 language tag to dub the project into (e.g. 'fr', 'es-419').
        /// </param>
        /// <param name="modelId">
        /// Dubbing model id for this target; omit to use the project default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost(
            string targetLanguage,
            string? modelId)
        {
            this.TargetLanguage = targetLanguage ?? throw new global::System.ArgumentNullException(nameof(targetLanguage));
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost" /> class.
        /// </summary>
        public BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost()
        {
        }

    }
}