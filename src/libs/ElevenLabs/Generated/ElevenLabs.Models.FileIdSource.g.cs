
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FileIdSource
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"file_id"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "file_id";

        /// <summary>
        /// The ID that `POST /v1/convai/conversations/{conversation_id}/files` returned for this conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileIdSource" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID that `POST /v1/convai/conversations/{conversation_id}/files` returned for this conversation.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileIdSource(
            string fileId,
            string type = "file_id")
        {
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileIdSource" /> class.
        /// </summary>
        public FileIdSource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="FileIdSource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static FileIdSource FromFileId(string fileId)
        {
            return new FileIdSource
            {
                FileId = fileId,
            };
        }

    }
}