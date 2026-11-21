
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"chunking_override":{"custom_separators":["\n### "],"max_chunk_size":800,"overlap_percentage":15},"effective_chunking_override":{"custom_separators":["\n### "],"max_chunk_size":800,"overlap_percentage":15},"id":"21m00Tcm4TlvDq8ikWAM","inherited_chunking_override":{"custom_separators":["\n## "],"max_chunk_size":500,"overlap_percentage":10}}
    /// </summary>
    public sealed partial class GetDocumentChunkingOverrideResponseModel
    {
        /// <summary>
        /// ID of the document or folder whose chunking settings were read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Override stored directly on this entity. Null means every setting is inherited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_override")]
        public global::ElevenLabs.ChunkingOverride? ChunkingOverride { get; set; }

        /// <summary>
        /// Effective override after merging this entity with its ancestor folders. Null fields use embedding model defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_chunking_override")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ChunkingOverride EffectiveChunkingOverride { get; set; }

        /// <summary>
        /// Override inherited from ancestor folders, ignoring this entity's own override. Null fields use embedding model defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherited_chunking_override")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ChunkingOverride InheritedChunkingOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentChunkingOverrideResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the document or folder whose chunking settings were read.
        /// </param>
        /// <param name="effectiveChunkingOverride">
        /// Effective override after merging this entity with its ancestor folders. Null fields use embedding model defaults.
        /// </param>
        /// <param name="inheritedChunkingOverride">
        /// Override inherited from ancestor folders, ignoring this entity's own override. Null fields use embedding model defaults.
        /// </param>
        /// <param name="chunkingOverride">
        /// Override stored directly on this entity. Null means every setting is inherited.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDocumentChunkingOverrideResponseModel(
            string id,
            global::ElevenLabs.ChunkingOverride effectiveChunkingOverride,
            global::ElevenLabs.ChunkingOverride inheritedChunkingOverride,
            global::ElevenLabs.ChunkingOverride? chunkingOverride)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ChunkingOverride = chunkingOverride;
            this.EffectiveChunkingOverride = effectiveChunkingOverride ?? throw new global::System.ArgumentNullException(nameof(effectiveChunkingOverride));
            this.InheritedChunkingOverride = inheritedChunkingOverride ?? throw new global::System.ArgumentNullException(nameof(inheritedChunkingOverride));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentChunkingOverrideResponseModel" /> class.
        /// </summary>
        public GetDocumentChunkingOverrideResponseModel()
        {
        }

    }
}