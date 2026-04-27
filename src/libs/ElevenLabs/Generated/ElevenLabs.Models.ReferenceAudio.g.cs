
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReferenceAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_item_id")]
        public string? HistoryItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_asset_id")]
        public string? ContentAssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_duration_seconds")]
        public double? EstimatedDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_node_id")]
        public string? TemplateNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("studio_clip")]
        public global::ElevenLabs.StudioClipReference? StudioClip { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceAudio" /> class.
        /// </summary>
        /// <param name="historyItemId"></param>
        /// <param name="contentAssetId"></param>
        /// <param name="generationId"></param>
        /// <param name="estimatedDurationSeconds"></param>
        /// <param name="templateNodeId"></param>
        /// <param name="studioClip"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReferenceAudio(
            string? historyItemId,
            string? contentAssetId,
            string? generationId,
            double? estimatedDurationSeconds,
            string? templateNodeId,
            global::ElevenLabs.StudioClipReference? studioClip)
        {
            this.HistoryItemId = historyItemId;
            this.ContentAssetId = contentAssetId;
            this.GenerationId = generationId;
            this.EstimatedDurationSeconds = estimatedDurationSeconds;
            this.TemplateNodeId = templateNodeId;
            this.StudioClip = studioClip;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceAudio" /> class.
        /// </summary>
        public ReferenceAudio()
        {
        }
    }
}