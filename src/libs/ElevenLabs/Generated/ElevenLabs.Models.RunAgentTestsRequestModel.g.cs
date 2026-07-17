
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunAgentTestsRequestModel
    {
        /// <summary>
        /// List of tests to run on the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.SingleTestRunRequestModel> Tests { get; set; }

        /// <summary>
        /// Configuration overrides to use for testing. If not provided, the agent's default configuration will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_config_override")]
        public global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel? AgentConfigOverride { get; set; }

        /// <summary>
        /// ID of the branch to run the tests on. If not provided, the tests will be run on the agent's main branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// Number of times to run each test. When greater than 1, results are grouped and summarized.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeat_count")]
        public int? RepeatCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAgentTestsRequestModel" /> class.
        /// </summary>
        /// <param name="tests">
        /// List of tests to run on the agent
        /// </param>
        /// <param name="agentConfigOverride">
        /// Configuration overrides to use for testing. If not provided, the agent's default configuration will be used.
        /// </param>
        /// <param name="branchId">
        /// ID of the branch to run the tests on. If not provided, the tests will be run on the agent's main branch.
        /// </param>
        /// <param name="repeatCount">
        /// Number of times to run each test. When greater than 1, results are grouped and summarized.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunAgentTestsRequestModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.SingleTestRunRequestModel> tests,
            global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel? agentConfigOverride,
            string? branchId,
            int? repeatCount)
        {
            this.Tests = tests ?? throw new global::System.ArgumentNullException(nameof(tests));
            this.AgentConfigOverride = agentConfigOverride;
            this.BranchId = branchId;
            this.RepeatCount = repeatCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAgentTestsRequestModel" /> class.
        /// </summary>
        public RunAgentTestsRequestModel()
        {
        }

    }
}