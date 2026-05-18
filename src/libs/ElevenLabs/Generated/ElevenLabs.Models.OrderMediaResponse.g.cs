
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"content_type":"video/mp4","language":"en","media_id":"prodmedia_01jgb2zd68f8f9tfvbb968wb8z","name":"example.mp4","signed_url":"https://storage.googleapis.com/example-bucket/media/example.mp4?X-Goog-Signature=..."}
    /// </summary>
    public sealed partial class OrderMediaResponse
    {
        /// <summary>
        /// The ID of the media file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaId { get; set; }

        /// <summary>
        /// The original filename of the uploaded media.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The MIME type of the media file (e.g. 'video/mp4').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// The detected or declared language of the media, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// A time-limited URL to download the media file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SignedUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderMediaResponse" /> class.
        /// </summary>
        /// <param name="mediaId">
        /// The ID of the media file.
        /// </param>
        /// <param name="name">
        /// The original filename of the uploaded media.
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the media file (e.g. 'video/mp4').
        /// </param>
        /// <param name="signedUrl">
        /// A time-limited URL to download the media file.
        /// </param>
        /// <param name="language">
        /// The detected or declared language of the media, if available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderMediaResponse(
            string mediaId,
            string name,
            string contentType,
            string signedUrl,
            string? language)
        {
            this.MediaId = mediaId ?? throw new global::System.ArgumentNullException(nameof(mediaId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Language = language;
            this.SignedUrl = signedUrl ?? throw new global::System.ArgumentNullException(nameof(signedUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderMediaResponse" /> class.
        /// </summary>
        public OrderMediaResponse()
        {
        }

    }
}