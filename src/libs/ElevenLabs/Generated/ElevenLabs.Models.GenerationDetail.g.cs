
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ModelIDJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ModelID ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        public string? Modality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_content")]
        public string? InlineContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_url")]
        public string? ContentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public double? DurationSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_ms")]
        public long? CreatedAtUnixMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationDetail" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="modelId"></param>
        /// <param name="modality"></param>
        /// <param name="prompt"></param>
        /// <param name="errorMessage"></param>
        /// <param name="inlineContent"></param>
        /// <param name="contentUrl"></param>
        /// <param name="thumbnailUrl"></param>
        /// <param name="durationSecs"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="createdAtUnixMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationDetail(
            string id,
            string status,
            global::ElevenLabs.ModelID modelId,
            string? modality,
            string? prompt,
            string? errorMessage,
            string? inlineContent,
            string? contentUrl,
            string? thumbnailUrl,
            double? durationSecs,
            int? width,
            int? height,
            long? createdAtUnixMs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.ModelId = modelId;
            this.Modality = modality;
            this.Prompt = prompt;
            this.ErrorMessage = errorMessage;
            this.InlineContent = inlineContent;
            this.ContentUrl = contentUrl;
            this.ThumbnailUrl = thumbnailUrl;
            this.DurationSecs = durationSecs;
            this.Width = width;
            this.Height = height;
            this.CreatedAtUnixMs = createdAtUnixMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationDetail" /> class.
        /// </summary>
        public GenerationDetail()
        {
        }
    }
}