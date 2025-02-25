
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QuoteRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_s")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SpeakerCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteRequestModel" /> class.
        /// </summary>
        /// <param name="contentHash"></param>
        /// <param name="durationS"></param>
        /// <param name="speakerCount"></param>
        /// <param name="language"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuoteRequestModel(
            string contentHash,
            double durationS,
            int speakerCount,
            string language)
        {
            this.ContentHash = contentHash ?? throw new global::System.ArgumentNullException(nameof(contentHash));
            this.DurationS = durationS;
            this.SpeakerCount = speakerCount;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteRequestModel" /> class.
        /// </summary>
        public QuoteRequestModel()
        {
        }
    }
}