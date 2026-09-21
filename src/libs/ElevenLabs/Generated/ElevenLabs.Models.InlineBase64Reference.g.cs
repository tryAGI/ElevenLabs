
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Media passed inline as base64. Stored as an ephemeral asset with no<br/>
    /// guaranteed retention. To keep an input and reuse it, upload via<br/>
    /// ``POST /v1/assets`` and pass an ``asset`` reference instead.
    /// </summary>
    public sealed partial class InlineBase64Reference
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
        /// The MIME type of the encoded media.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.InlineBase64ReferenceMimeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.InlineBase64ReferenceMimeType MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineBase64Reference" /> class.
        /// </summary>
        /// <param name="contentBase64">
        /// The media file's bytes, base64-encoded (standard alphabet). Up to 25MB decoded.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the encoded media.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlineBase64Reference(
            string contentBase64,
            global::ElevenLabs.InlineBase64ReferenceMimeType mimeType,
            string type = "inline_base64")
        {
            this.Type = type;
            this.ContentBase64 = contentBase64 ?? throw new global::System.ArgumentNullException(nameof(contentBase64));
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineBase64Reference" /> class.
        /// </summary>
        public InlineBase64Reference()
        {
        }

    }
}