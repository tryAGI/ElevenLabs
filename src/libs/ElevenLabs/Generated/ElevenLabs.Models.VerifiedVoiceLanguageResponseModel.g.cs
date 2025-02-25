
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VerifiedVoiceLanguageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifiedVoiceLanguageResponseModel" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="modelId"></param>
        /// <param name="accent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifiedVoiceLanguageResponseModel(
            string language,
            string modelId,
            string? accent)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Accent = accent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifiedVoiceLanguageResponseModel" /> class.
        /// </summary>
        public VerifiedVoiceLanguageResponseModel()
        {
        }
    }
}