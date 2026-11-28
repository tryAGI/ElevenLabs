
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"chunking_override":{"custom_separators":["\n## "],"max_chunk_size":800,"overlap_percentage":10},"id":"21m00Tcm4TlvDq8ikWAM","reindex_queued":true}
    /// </summary>
    public sealed partial class UpdateDocumentChunkingOverrideResponseModel
    {
        /// <summary>
        /// ID of the document or folder whose chunking override was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The resulting chunking override. Null means the entity inherits from ancestors or the embedding model default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_override")]
        public global::ElevenLabs.ChunkingOverride? ChunkingOverride { get; set; }

        /// <summary>
        /// Whether the effective configuration changed and background reindexing was queued.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reindex_queued")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReindexQueued { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentChunkingOverrideResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the document or folder whose chunking override was updated.
        /// </param>
        /// <param name="reindexQueued">
        /// Whether the effective configuration changed and background reindexing was queued.
        /// </param>
        /// <param name="chunkingOverride">
        /// The resulting chunking override. Null means the entity inherits from ancestors or the embedding model default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDocumentChunkingOverrideResponseModel(
            string id,
            bool reindexQueued,
            global::ElevenLabs.ChunkingOverride? chunkingOverride)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ChunkingOverride = chunkingOverride;
            this.ReindexQueued = reindexQueued;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentChunkingOverrideResponseModel" /> class.
        /// </summary>
        public UpdateDocumentChunkingOverrideResponseModel()
        {
        }

    }
}