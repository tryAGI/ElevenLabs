#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsWorkspaceAnalyticsClient
    {
        /// <summary>
        /// Run Conversation Analysis<br/>
        /// Run the analysis for a conversation using the agent's current evaluation criteria and data collection settings.
        /// </summary>
        /// <param name="conversationId">
        /// ID of the conversation
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConversationResponseModel> RunAsync(
            string conversationId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}