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
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConversationResponseModel> RunAsync(
            string conversationId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}