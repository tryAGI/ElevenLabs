
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResubmitTestsRequestModel
    {
        /// <summary>
        /// List of test run IDs to resubmit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_run_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TestRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_config_override")]
        public global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel? AgentConfigOverride { get; set; }

        /// <summary>
        /// Agent ID to resubmit tests for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResubmitTestsRequestModel" /> class.
        /// </summary>
        /// <param name="testRunIds">
        /// List of test run IDs to resubmit
        /// </param>
        /// <param name="agentConfigOverride"></param>
        /// <param name="agentId">
        /// Agent ID to resubmit tests for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResubmitTestsRequestModel(
            global::System.Collections.Generic.IList<string> testRunIds,
            string agentId,
            global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel? agentConfigOverride)
        {
            this.TestRunIds = testRunIds ?? throw new global::System.ArgumentNullException(nameof(testRunIds));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentConfigOverride = agentConfigOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResubmitTestsRequestModel" /> class.
        /// </summary>
        public ResubmitTestsRequestModel()
        {
        }
    }
}