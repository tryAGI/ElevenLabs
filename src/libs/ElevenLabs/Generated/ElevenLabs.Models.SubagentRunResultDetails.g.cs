
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubagentRunResultDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_conversation_id")]
        public string? SubConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubagentRunResultDetails" /> class.
        /// </summary>
        /// <param name="subConversationId"></param>
        /// <param name="agentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubagentRunResultDetails(
            string? subConversationId,
            string? agentId)
        {
            this.SubConversationId = subConversationId;
            this.AgentId = agentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubagentRunResultDetails" /> class.
        /// </summary>
        public SubagentRunResultDetails()
        {
        }

    }
}