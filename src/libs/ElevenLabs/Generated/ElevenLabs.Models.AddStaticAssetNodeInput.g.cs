
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddStaticAssetNodeInput
    {
        /// <summary>
        /// The type of static asset: 'image', 'video', 'audio', or 'text'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AddStaticAssetNodeInputModalityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AddStaticAssetNodeInputModality Modality { get; set; }

        /// <summary>
        /// ID of the uploaded asset. Required for image, video, and audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_asset_id")]
        public string? ContentAssetId { get; set; }

        /// <summary>
        /// Text content for text nodes. Required for text modality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_text")]
        public string? InlineText { get; set; }

        /// <summary>
        /// Optional display label for the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddStaticAssetNodeInput" /> class.
        /// </summary>
        /// <param name="modality">
        /// The type of static asset: 'image', 'video', 'audio', or 'text'.
        /// </param>
        /// <param name="contentAssetId">
        /// ID of the uploaded asset. Required for image, video, and audio.
        /// </param>
        /// <param name="inlineText">
        /// Text content for text nodes. Required for text modality.
        /// </param>
        /// <param name="label">
        /// Optional display label for the node.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddStaticAssetNodeInput(
            global::ElevenLabs.AddStaticAssetNodeInputModality modality,
            string? contentAssetId,
            string? inlineText,
            string? label)
        {
            this.Modality = modality;
            this.ContentAssetId = contentAssetId;
            this.InlineText = inlineText;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddStaticAssetNodeInput" /> class.
        /// </summary>
        public AddStaticAssetNodeInput()
        {
        }
    }
}