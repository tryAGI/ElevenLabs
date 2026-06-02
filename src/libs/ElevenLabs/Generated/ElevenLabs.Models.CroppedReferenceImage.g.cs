
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CroppedReferenceImage
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("video_image_at_secs")]
        public double? VideoImageAtSecs { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_context")]
        public global::ElevenLabs.AvatarContext? AvatarContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_left")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CropLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_top")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CropTop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_right")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CropRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_bottom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CropBottom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CroppedReferenceImage" /> class.
        /// </summary>
        /// <param name="cropLeft"></param>
        /// <param name="cropTop"></param>
        /// <param name="cropRight"></param>
        /// <param name="cropBottom"></param>
        /// <param name="contentAssetId"></param>
        /// <param name="generationId"></param>
        /// <param name="videoImageAtSecs"></param>
        /// <param name="templateNodeId"></param>
        /// <param name="studioClip"></param>
        /// <param name="avatarContext"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CroppedReferenceImage(
            int cropLeft,
            int cropTop,
            int cropRight,
            int cropBottom,
            string? contentAssetId,
            string? generationId,
            double? videoImageAtSecs,
            string? templateNodeId,
            global::ElevenLabs.StudioClipReference? studioClip,
            global::ElevenLabs.AvatarContext? avatarContext)
        {
            this.ContentAssetId = contentAssetId;
            this.GenerationId = generationId;
            this.VideoImageAtSecs = videoImageAtSecs;
            this.TemplateNodeId = templateNodeId;
            this.StudioClip = studioClip;
            this.AvatarContext = avatarContext;
            this.CropLeft = cropLeft;
            this.CropTop = cropTop;
            this.CropRight = cropRight;
            this.CropBottom = cropBottom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CroppedReferenceImage" /> class.
        /// </summary>
        public CroppedReferenceImage()
        {
        }

    }
}