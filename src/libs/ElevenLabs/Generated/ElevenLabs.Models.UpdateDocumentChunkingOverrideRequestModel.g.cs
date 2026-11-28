
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateDocumentChunkingOverrideRequestModel
    {
        /// <summary>
        /// RAG chunking override for a document or folder. Null clears the override so ancestors and embedding model defaults apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_override")]
        public global::ElevenLabs.ChunkingOverrideRequestModel? ChunkingOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentChunkingOverrideRequestModel" /> class.
        /// </summary>
        /// <param name="chunkingOverride">
        /// RAG chunking override for a document or folder. Null clears the override so ancestors and embedding model defaults apply.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDocumentChunkingOverrideRequestModel(
            global::ElevenLabs.ChunkingOverrideRequestModel? chunkingOverride)
        {
            this.ChunkingOverride = chunkingOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentChunkingOverrideRequestModel" /> class.
        /// </summary>
        public UpdateDocumentChunkingOverrideRequestModel()
        {
        }

    }
}