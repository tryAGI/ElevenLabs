#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsWorkspaceAnalyticsClient
    {
        /// <summary>
        /// Run Conversation Evaluation<br/>
        /// Rerun a specific evaluation for a conversation.
        /// </summary>
        /// <param name="conversationId">
        /// ID of the conversation
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConversationResponseModel> RunEvaluationAsync(
            string conversationId,

            global::ElevenLabs.RunConversationEvaluationsRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Conversation Evaluation<br/>
        /// Rerun a specific evaluation for a conversation.
        /// </summary>
        /// <param name="conversationId">
        /// ID of the conversation
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetConversationResponseModel>> RunEvaluationAsResponseAsync(
            string conversationId,

            global::ElevenLabs.RunConversationEvaluationsRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Conversation Evaluation<br/>
        /// Rerun a specific evaluation for a conversation.
        /// </summary>
        /// <param name="conversationId">
        /// ID of the conversation
        /// </param>
        /// <param name="evaluationId">
        /// ID of the single evaluation criterion to rerun.
        /// </param>
        /// <param name="scope">
        /// Default Value: conversation
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConversationResponseModel> RunEvaluationAsync(
            string conversationId,
            string evaluationId,
            global::ElevenLabs.AnalysisScope? scope = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}