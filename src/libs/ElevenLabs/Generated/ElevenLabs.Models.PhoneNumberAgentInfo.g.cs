
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"agent_id":"F3Pbu5gP6NNKBscdCdwB","agent_name":"My Agent"}
    /// </summary>
    public sealed partial class PhoneNumberAgentInfo
    {
        /// <summary>
        /// The ID of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The name of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// Environment to use for resolving environment variables on calls to this number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Agent branch to use for calls to this number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberAgentInfo" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent
        /// </param>
        /// <param name="agentName">
        /// The name of the agent
        /// </param>
        /// <param name="environment">
        /// Environment to use for resolving environment variables on calls to this number.
        /// </param>
        /// <param name="branchId">
        /// Agent branch to use for calls to this number.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberAgentInfo(
            string agentId,
            string agentName,
            string? environment,
            string? branchId)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.Environment = environment;
            this.BranchId = branchId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberAgentInfo" /> class.
        /// </summary>
        public PhoneNumberAgentInfo()
        {
        }

    }
}