
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CanvasSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalNodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_edges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalEdges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> NodeTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CanvasSummary" /> class.
        /// </summary>
        /// <param name="totalNodes"></param>
        /// <param name="totalEdges"></param>
        /// <param name="nodeTypes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CanvasSummary(
            int totalNodes,
            int totalEdges,
            global::System.Collections.Generic.Dictionary<string, int> nodeTypes)
        {
            this.TotalNodes = totalNodes;
            this.TotalEdges = totalEdges;
            this.NodeTypes = nodeTypes ?? throw new global::System.ArgumentNullException(nameof(nodeTypes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CanvasSummary" /> class.
        /// </summary>
        public CanvasSummary()
        {
        }
    }
}