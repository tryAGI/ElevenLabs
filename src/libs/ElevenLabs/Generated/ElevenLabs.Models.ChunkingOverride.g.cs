
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChunkingOverride
    {
        /// <summary>
        /// Maximum chunk size in tokens. Null uses the inherited value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_chunk_size")]
        public int? MaxChunkSize { get; set; }

        /// <summary>
        /// Chunk overlap as a percentage of the chunk size. Null uses the inherited value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlap_percentage")]
        public int? OverlapPercentage { get; set; }

        /// <summary>
        /// Custom text separators used when splitting. Null uses the inherited value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_separators")]
        public global::System.Collections.Generic.IList<string>? CustomSeparators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkingOverride" /> class.
        /// </summary>
        /// <param name="maxChunkSize">
        /// Maximum chunk size in tokens. Null uses the inherited value.
        /// </param>
        /// <param name="overlapPercentage">
        /// Chunk overlap as a percentage of the chunk size. Null uses the inherited value.
        /// </param>
        /// <param name="customSeparators">
        /// Custom text separators used when splitting. Null uses the inherited value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChunkingOverride(
            int? maxChunkSize,
            int? overlapPercentage,
            global::System.Collections.Generic.IList<string>? customSeparators)
        {
            this.MaxChunkSize = maxChunkSize;
            this.OverlapPercentage = overlapPercentage;
            this.CustomSeparators = customSeparators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkingOverride" /> class.
        /// </summary>
        public ChunkingOverride()
        {
        }

    }
}