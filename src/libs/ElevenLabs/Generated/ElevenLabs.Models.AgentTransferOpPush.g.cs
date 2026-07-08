
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentTransferOpPush
    {
        /// <summary>
        /// Default Value: push
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_node_id")]
        public string? ReturnNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransferOpPush" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: push
        /// </param>
        /// <param name="returnNodeId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTransferOpPush(
            string? type,
            string? returnNodeId)
        {
            this.Type = type;
            this.ReturnNodeId = returnNodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransferOpPush" /> class.
        /// </summary>
        public AgentTransferOpPush()
        {
        }

    }
}