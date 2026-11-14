
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Base64FileSource
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"base64"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "base64";

        /// <summary>
        /// The name of the file, with its extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.FileInputMimeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.FileInputMimeType MediaType { get; set; }

        /// <summary>
        /// The content of the file, base64-encoded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Base64FileSource" /> class.
        /// </summary>
        /// <param name="filename">
        /// The name of the file, with its extension.
        /// </param>
        /// <param name="mediaType"></param>
        /// <param name="data">
        /// The content of the file, base64-encoded.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Base64FileSource(
            string filename,
            global::ElevenLabs.FileInputMimeType mediaType,
            string data,
            string type = "base64")
        {
            this.Type = type;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.MediaType = mediaType;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Base64FileSource" /> class.
        /// </summary>
        public Base64FileSource()
        {
        }

    }
}