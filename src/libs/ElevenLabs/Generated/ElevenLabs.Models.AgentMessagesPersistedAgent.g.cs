
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentMessagesPersistedAgent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"persisted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "persisted";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// ID of the agent branch to use for this conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// Changes to the agent configuration for this conversation. The agent must allow each field that is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::ElevenLabs.AgentMessagesOverrides? Overrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMessagesPersistedAgent" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="branchId">
        /// ID of the agent branch to use for this conversation
        /// </param>
        /// <param name="overrides">
        /// Changes to the agent configuration for this conversation. The agent must allow each field that is set.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMessagesPersistedAgent(
            string agentId,
            string? branchId,
            global::ElevenLabs.AgentMessagesOverrides? overrides,
            string type = "persisted")
        {
            this.Type = type;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.BranchId = branchId;
            this.Overrides = overrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMessagesPersistedAgent" /> class.
        /// </summary>
        public AgentMessagesPersistedAgent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AgentMessagesPersistedAgent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AgentMessagesPersistedAgent FromAgentId(string agentId)
        {
            return new AgentMessagesPersistedAgent
            {
                AgentId = agentId,
            };
        }

    }
}