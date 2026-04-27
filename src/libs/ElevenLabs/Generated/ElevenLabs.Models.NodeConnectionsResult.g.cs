
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeConnectionsResult
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
        [global::System.Text.Json.Serialization.JsonPropertyName("node_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_text")]
        public string? PromptText { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_references")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.NodeRef>? ConnectedReferences { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_unconnected_nodes")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AvailableNode>? AvailableUnconnectedNodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeConnectionsResult" /> class.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="nodeLabel"></param>
        /// <param name="promptText"></param>
        /// <param name="connectedReferences">
        /// Default Value: []
        /// </param>
        /// <param name="availableUnconnectedNodes">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeConnectionsResult(
            string nodeId,
            string nodeLabel,
            string? promptText,
            global::System.Collections.Generic.IList<global::ElevenLabs.NodeRef>? connectedReferences,
            global::System.Collections.Generic.IList<global::ElevenLabs.AvailableNode>? availableUnconnectedNodes)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.NodeLabel = nodeLabel ?? throw new global::System.ArgumentNullException(nameof(nodeLabel));
            this.PromptText = promptText;
            this.ConnectedReferences = connectedReferences;
            this.AvailableUnconnectedNodes = availableUnconnectedNodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeConnectionsResult" /> class.
        /// </summary>
        public NodeConnectionsResult()
        {
        }
    }
}