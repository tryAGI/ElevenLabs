
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharedSoundGenerationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HistoryItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchased_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PurchasedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("like_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LikeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Featured { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviewUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchased")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Purchased { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IconUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSoundGenerationResponseModel" /> class.
        /// </summary>
        /// <param name="publicUserId"></param>
        /// <param name="historyItemId"></param>
        /// <param name="generationId"></param>
        /// <param name="text"></param>
        /// <param name="category"></param>
        /// <param name="labels"></param>
        /// <param name="purchasedCount"></param>
        /// <param name="likeCount"></param>
        /// <param name="featured"></param>
        /// <param name="previewUrl"></param>
        /// <param name="purchased"></param>
        /// <param name="iconUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedSoundGenerationResponseModel(
            string publicUserId,
            string historyItemId,
            string generationId,
            string text,
            string category,
            global::System.Collections.Generic.Dictionary<string, string> labels,
            int purchasedCount,
            int likeCount,
            bool featured,
            string previewUrl,
            bool purchased,
            string iconUrl)
        {
            this.PublicUserId = publicUserId ?? throw new global::System.ArgumentNullException(nameof(publicUserId));
            this.HistoryItemId = historyItemId ?? throw new global::System.ArgumentNullException(nameof(historyItemId));
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.PurchasedCount = purchasedCount;
            this.LikeCount = likeCount;
            this.Featured = featured;
            this.PreviewUrl = previewUrl ?? throw new global::System.ArgumentNullException(nameof(previewUrl));
            this.Purchased = purchased;
            this.IconUrl = iconUrl ?? throw new global::System.ArgumentNullException(nameof(iconUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSoundGenerationResponseModel" /> class.
        /// </summary>
        public SharedSoundGenerationResponseModel()
        {
        }
    }
}