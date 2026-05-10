
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An agent (and optional branch) that participated in the call, in first-seen transcript order.
    /// </summary>
    public sealed partial class VisitedAgentRef
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitedAgentRef" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="branchId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VisitedAgentRef(
            string agentId,
            string? branchId)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.BranchId = branchId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitedAgentRef" /> class.
        /// </summary>
        public VisitedAgentRef()
        {
        }

    }
}