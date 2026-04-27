
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DisconnectSpec
    {
        /// <summary>
        /// ID of the source node to disconnect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceNodeId { get; set; }

        /// <summary>
        /// ID of the target node to disconnect from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DisconnectSpec" /> class.
        /// </summary>
        /// <param name="sourceNodeId">
        /// ID of the source node to disconnect.
        /// </param>
        /// <param name="targetNodeId">
        /// ID of the target node to disconnect from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DisconnectSpec(
            string sourceNodeId,
            string targetNodeId)
        {
            this.SourceNodeId = sourceNodeId ?? throw new global::System.ArgumentNullException(nameof(sourceNodeId));
            this.TargetNodeId = targetNodeId ?? throw new global::System.ArgumentNullException(nameof(targetNodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisconnectSpec" /> class.
        /// </summary>
        public DisconnectSpec()
        {
        }
    }
}