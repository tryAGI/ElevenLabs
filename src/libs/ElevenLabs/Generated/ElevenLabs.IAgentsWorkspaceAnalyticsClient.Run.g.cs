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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConversationResponseModel> RunAsync(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}