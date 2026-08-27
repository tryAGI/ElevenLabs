
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An image passed inline as base64. The image is stored as an ephemeral<br/>
    /// asset with no guaranteed retention: it may be deleted at any time after<br/>
    /// the generation completes. To keep an input and reuse it across<br/>
    /// generations, upload it via the assets API (`POST /v1/assets`) and pass<br/>
    /// an `asset` reference instead.
    /// </summary>
    public sealed partial class InlineImageReference
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"inline_base64"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "inline_base64";

        /// <summary>
        /// The media file's bytes, base64-encoded (standard alphabet). Up to 25MB decoded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_base64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentBase64 { get; set; }

        /// <summary>
        /// The MIME type of the encoded image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.InlineImageReferenceMimeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.InlineImageReferenceMimeType MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineImageReference" /> class.
        /// </summary>
        /// <param name="contentBase64">
        /// The media file's bytes, base64-encoded (standard alphabet). Up to 25MB decoded.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the encoded image.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlineImageReference(
            string contentBase64,
            global::ElevenLabs.InlineImageReferenceMimeType mimeType,
            string type = "inline_base64")
        {
            this.Type = type;
            this.ContentBase64 = contentBase64 ?? throw new global::System.ArgumentNullException(nameof(contentBase64));
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineImageReference" /> class.
        /// </summary>
        public InlineImageReference()
        {
        }

    }
}