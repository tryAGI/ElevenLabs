
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A completed media generation and its output.<br/>
    /// Example: {"content_mime_type":"video/mp4","content_url":"https://storage.googleapis.com/generations/JWr5N6X9ZTqf8jD2LmQb","id":"JWr5N6X9ZTqf8jD2LmQb","status":"completed"}
    /// </summary>
    public sealed partial class MediaGenerationCompletedResponse
    {
        /// <summary>
        /// The unique identifier of the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The lifecycle status of the generation.
        /// </summary>
        /// <default>"completed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "completed";

        /// <summary>
        /// A signed URL to download the generated media from. It expires about an hour after this response is returned; fetch the generation again for a fresh URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentUrl { get; set; }

        /// <summary>
        /// The MIME type of the generated media.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentMimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaGenerationCompletedResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the generation.
        /// </param>
        /// <param name="contentUrl">
        /// A signed URL to download the generated media from. It expires about an hour after this response is returned; fetch the generation again for a fresh URL.
        /// </param>
        /// <param name="contentMimeType">
        /// The MIME type of the generated media.
        /// </param>
        /// <param name="status">
        /// The lifecycle status of the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaGenerationCompletedResponse(
            string id,
            string contentUrl,
            string contentMimeType,
            string status = "completed")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.ContentUrl = contentUrl ?? throw new global::System.ArgumentNullException(nameof(contentUrl));
            this.ContentMimeType = contentMimeType ?? throw new global::System.ArgumentNullException(nameof(contentMimeType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaGenerationCompletedResponse" /> class.
        /// </summary>
        public MediaGenerationCompletedResponse()
        {
        }

    }
}