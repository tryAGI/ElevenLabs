
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnitTestRunResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_invocation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestInvocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TestRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TestRunStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_responses")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>? AgentResponses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition_result")]
        public global::ElevenLabs.TestConditionResultCommonModel? ConditionResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestRunResponseModel" /> class.
        /// </summary>
        /// <param name="testRunId"></param>
        /// <param name="testInvocationId"></param>
        /// <param name="agentId"></param>
        /// <param name="status"></param>
        /// <param name="agentResponses"></param>
        /// <param name="testId"></param>
        /// <param name="conditionResult"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnitTestRunResponseModel(
            string testRunId,
            string testInvocationId,
            string agentId,
            global::ElevenLabs.TestRunStatus status,
            string testId,
            global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput>? agentResponses,
            global::ElevenLabs.TestConditionResultCommonModel? conditionResult)
        {
            this.TestRunId = testRunId ?? throw new global::System.ArgumentNullException(nameof(testRunId));
            this.TestInvocationId = testInvocationId ?? throw new global::System.ArgumentNullException(nameof(testInvocationId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Status = status;
            this.TestId = testId ?? throw new global::System.ArgumentNullException(nameof(testId));
            this.AgentResponses = agentResponses;
            this.ConditionResult = conditionResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestRunResponseModel" /> class.
        /// </summary>
        public UnitTestRunResponseModel()
        {
        }
    }
}