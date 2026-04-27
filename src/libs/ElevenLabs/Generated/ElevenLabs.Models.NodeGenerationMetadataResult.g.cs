
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeGenerationMetadataResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_generation_id")]
        public string? ActiveGenerationId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.GenerationBrief>? Generations { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public global::System.Collections.Generic.IList<string>? Notes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeGenerationMetadataResult" /> class.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="nodeType"></param>
        /// <param name="activeGenerationId"></param>
        /// <param name="generations">
        /// Default Value: []
        /// </param>
        /// <param name="notes">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeGenerationMetadataResult(
            string nodeId,
            string nodeType,
            string? activeGenerationId,
            global::System.Collections.Generic.IList<global::ElevenLabs.GenerationBrief>? generations,
            global::System.Collections.Generic.IList<string>? notes)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.NodeType = nodeType ?? throw new global::System.ArgumentNullException(nameof(nodeType));
            this.ActiveGenerationId = activeGenerationId;
            this.Generations = generations;
            this.Notes = notes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeGenerationMetadataResult" /> class.
        /// </summary>
        public NodeGenerationMetadataResult()
        {
        }
    }
}