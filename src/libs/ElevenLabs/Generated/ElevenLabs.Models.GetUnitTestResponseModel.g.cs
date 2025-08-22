
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUnitTestResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_history")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput> ChatHistory { get; set; }

        /// <summary>
        /// A prompt that evaluates whether the agent's response is successful. Should return True or False.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SuccessCondition { get; set; }

        /// <summary>
        /// Non-empty list of example responses that should be considered successful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AgentSuccessfulResponseExample> SuccessExamples { get; set; }

        /// <summary>
        /// Non-empty list of example responses that should be considered failures
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AgentFailureResponseExample> FailureExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_parameters")]
        public global::ElevenLabs.UnitTestToolCallEvaluationModelOutput? ToolCallParameters { get; set; }

        /// <summary>
        /// Dynamic variables to replace in the agent config during testing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUnitTestResponseModel" /> class.
        /// </summary>
        /// <param name="chatHistory"></param>
        /// <param name="successCondition">
        /// A prompt that evaluates whether the agent's response is successful. Should return True or False.
        /// </param>
        /// <param name="successExamples">
        /// Non-empty list of example responses that should be considered successful
        /// </param>
        /// <param name="failureExamples">
        /// Non-empty list of example responses that should be considered failures
        /// </param>
        /// <param name="toolCallParameters"></param>
        /// <param name="dynamicVariables">
        /// Dynamic variables to replace in the agent config during testing
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUnitTestResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput> chatHistory,
            string successCondition,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentSuccessfulResponseExample> successExamples,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentFailureResponseExample> failureExamples,
            string id,
            string name,
            global::ElevenLabs.UnitTestToolCallEvaluationModelOutput? toolCallParameters,
            object? dynamicVariables)
        {
            this.ChatHistory = chatHistory ?? throw new global::System.ArgumentNullException(nameof(chatHistory));
            this.SuccessCondition = successCondition ?? throw new global::System.ArgumentNullException(nameof(successCondition));
            this.SuccessExamples = successExamples ?? throw new global::System.ArgumentNullException(nameof(successExamples));
            this.FailureExamples = failureExamples ?? throw new global::System.ArgumentNullException(nameof(failureExamples));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ToolCallParameters = toolCallParameters;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUnitTestResponseModel" /> class.
        /// </summary>
        public GetUnitTestResponseModel()
        {
        }
    }
}