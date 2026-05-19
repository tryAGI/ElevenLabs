
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyRegisterMediaV1ProductionsOrdersOrderIdMediaPost
    {
        /// <summary>
        /// The language code of the media content (e.g. 'en', 'es-ES'). Must be a supported source language for some order item kind.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeclaredLanguage { get; set; }

        /// <summary>
        /// The media file to upload. Mutually exclusive with media_url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        public byte[]? Media { get; set; }

        /// <summary>
        /// The media file to upload. Mutually exclusive with media_url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medianame")]
        public string? Medianame { get; set; }

        /// <summary>
        /// A URL to fetch the media file from. Mutually exclusive with media.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_url")]
        public string? MediaUrl { get; set; }

        /// <summary>
        /// The filename for URL-sourced media (e.g. 'example.mp4'). Required when using media_url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_url_filename")]
        public string? MediaUrlFilename { get; set; }

        /// <summary>
        /// The MIME type for URL-sourced media (e.g. 'video/mp4'). Required when using media_url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_url_content_type")]
        public string? MediaUrlContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRegisterMediaV1ProductionsOrdersOrderIdMediaPost" /> class.
        /// </summary>
        /// <param name="declaredLanguage">
        /// The language code of the media content (e.g. 'en', 'es-ES'). Must be a supported source language for some order item kind.
        /// </param>
        /// <param name="media">
        /// The media file to upload. Mutually exclusive with media_url.
        /// </param>
        /// <param name="medianame">
        /// The media file to upload. Mutually exclusive with media_url.
        /// </param>
        /// <param name="mediaUrl">
        /// A URL to fetch the media file from. Mutually exclusive with media.
        /// </param>
        /// <param name="mediaUrlFilename">
        /// The filename for URL-sourced media (e.g. 'example.mp4'). Required when using media_url.
        /// </param>
        /// <param name="mediaUrlContentType">
        /// The MIME type for URL-sourced media (e.g. 'video/mp4'). Required when using media_url.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyRegisterMediaV1ProductionsOrdersOrderIdMediaPost(
            string declaredLanguage,
            byte[]? media,
            string? medianame,
            string? mediaUrl,
            string? mediaUrlFilename,
            string? mediaUrlContentType)
        {
            this.DeclaredLanguage = declaredLanguage ?? throw new global::System.ArgumentNullException(nameof(declaredLanguage));
            this.Media = media;
            this.Medianame = medianame;
            this.MediaUrl = mediaUrl;
            this.MediaUrlFilename = mediaUrlFilename;
            this.MediaUrlContentType = mediaUrlContentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRegisterMediaV1ProductionsOrdersOrderIdMediaPost" /> class.
        /// </summary>
        public BodyRegisterMediaV1ProductionsOrdersOrderIdMediaPost()
        {
        }

    }
}