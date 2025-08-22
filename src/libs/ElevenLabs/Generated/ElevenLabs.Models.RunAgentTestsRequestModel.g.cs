
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_config_override")]
        public global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel? AgentConfigOverride { get; set; }

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
        /// <param name="agentConfigOverride"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunAgentTestsRequestModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.SingleTestRunRequestModel> tests,
            global::ElevenLabs.AdhocAgentConfigOverrideForTestRequestModel? agentConfigOverride)
        {
            this.Tests = tests ?? throw new global::System.ArgumentNullException(nameof(tests));
            this.AgentConfigOverride = agentConfigOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAgentTestsRequestModel" /> class.
        /// </summary>
        public RunAgentTestsRequestModel()
        {
        }
    }
}