#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Get Conversations<br/>
        /// Get all conversations of agents that user owns. With option to restrict to a specific agent.
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="agentId">
        /// The id of the agent you're taking the action on.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="callSuccessful"></param>
        /// <param name="callStartBeforeUnix">
        /// Unix timestamp (in seconds) to filter conversations up to this start date.
        /// </param>
        /// <param name="callStartAfterUnix">
        /// Unix timestamp (in seconds) to filter conversations after to this start date.
        /// </param>
        /// <param name="userId">
        /// Filter conversations by the user ID who initiated them.
        /// </param>
        /// <param name="pageSize">
        /// How many conversations to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="summaryMode">
        /// Whether to include transcript summaries in the response.<br/>
        /// Default Value: exclude
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConversationsPageResponseModel> GetConvaiConversationsAsync(
            string? cursor = default,
            string? agentId = default,
            global::ElevenLabs.EvaluationSuccessResult? callSuccessful = default,
            global::System.DateTimeOffset? callStartBeforeUnix = default,
            global::System.DateTimeOffset? callStartAfterUnix = default,
            string? userId = default,
            int? pageSize = default,
            global::ElevenLabs.GetConversationHistoriesRouteSummaryMode? summaryMode = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}