#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// Update Agent Response Test<br/>
        /// Updates an agent response test by ID.
        /// </summary>
        /// <param name="testId">
        /// The id of a chat response test. This is returned on test creation.<br/>
        /// Example: TeaqRRdTcIfIu2i7BYfT
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetUnitTestResponseModel> PutConvaiAgentTestingByTestIdAsync(
            string testId,
            global::ElevenLabs.UpdateUnitTestRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Agent Response Test<br/>
        /// Updates an agent response test by ID.
        /// </summary>
        /// <param name="testId">
        /// The id of a chat response test. This is returned on test creation.<br/>
        /// Example: TeaqRRdTcIfIu2i7BYfT
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
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
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetUnitTestResponseModel> PutConvaiAgentTestingByTestIdAsync(
            string testId,
            global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelInput> chatHistory,
            string successCondition,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentSuccessfulResponseExample> successExamples,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentFailureResponseExample> failureExamples,
            string name,
            string? xiApiKey = default,
            global::ElevenLabs.UnitTestToolCallEvaluationModelInput? toolCallParameters = default,
            object? dynamicVariables = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}