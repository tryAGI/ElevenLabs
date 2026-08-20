#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsInsightsClient
    {
        /// <summary>
        /// Get Agent Conversation Topics<br/>
        /// Returns the latest topic discovery run results for a given agent.
        /// </summary>
        /// <param name="agentId">
        /// ID of the agent
        /// </param>
        /// <param name="pageSize">
        /// Number of top-level topic groups to return.
        /// </param>
        /// <param name="sortBy">
        /// Column to rank topics by. Use conversations for volume, sentiment with sort_direction=asc for the most negative topics, and frustration with sort_direction=desc for the most frustrated ones. Topics with no score are always ranked last.<br/>
        /// Default Value: conversations
        /// </param>
        /// <param name="sortDirection">
        /// Direction to sort topics.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="fromUnixSecs">
        /// Start of the window to view topics for. When set with to_unix_secs, the completed daily topic-discovery runs in the range are aggregated together, so the window scopes the metrics as well as the topic set. Floored to the start of its UTC day because runs cover whole UTC days; aggregated_run_count reports how many runs were summed. Omit both bounds to get the single latest run.
        /// </param>
        /// <param name="toUnixSecs">
        /// End of the window to view topics for.
        /// </param>
        /// <param name="includeEvaluationCriteria">
        /// Include the per-criteria evaluation breakdown on each topic's metrics. Pass false to drop it: it dominates the payload and the weighted success_rate is returned either way.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentTopicsResponseModel> GetAsync(
            string agentId,
            int? pageSize = default,
            global::ElevenLabs.TopicSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            int? fromUnixSecs = default,
            int? toUnixSecs = default,
            bool? includeEvaluationCriteria = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Conversation Topics<br/>
        /// Returns the latest topic discovery run results for a given agent.
        /// </summary>
        /// <param name="agentId">
        /// ID of the agent
        /// </param>
        /// <param name="pageSize">
        /// Number of top-level topic groups to return.
        /// </param>
        /// <param name="sortBy">
        /// Column to rank topics by. Use conversations for volume, sentiment with sort_direction=asc for the most negative topics, and frustration with sort_direction=desc for the most frustrated ones. Topics with no score are always ranked last.<br/>
        /// Default Value: conversations
        /// </param>
        /// <param name="sortDirection">
        /// Direction to sort topics.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="fromUnixSecs">
        /// Start of the window to view topics for. When set with to_unix_secs, the completed daily topic-discovery runs in the range are aggregated together, so the window scopes the metrics as well as the topic set. Floored to the start of its UTC day because runs cover whole UTC days; aggregated_run_count reports how many runs were summed. Omit both bounds to get the single latest run.
        /// </param>
        /// <param name="toUnixSecs">
        /// End of the window to view topics for.
        /// </param>
        /// <param name="includeEvaluationCriteria">
        /// Include the per-criteria evaluation breakdown on each topic's metrics. Pass false to drop it: it dominates the payload and the weighted success_rate is returned either way.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetAgentTopicsResponseModel>> GetAsResponseAsync(
            string agentId,
            int? pageSize = default,
            global::ElevenLabs.TopicSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            int? fromUnixSecs = default,
            int? toUnixSecs = default,
            bool? includeEvaluationCriteria = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps GetAsync as an IAsyncEnumerable&lt;global::ElevenLabs.AgentTopicResponseModel&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="agentId">
        /// ID of the agent
        /// </param>
        /// <param name="pageSize">
        /// Number of top-level topic groups to return.
        /// </param>
        /// <param name="sortBy">
        /// Column to rank topics by. Use conversations for volume, sentiment with sort_direction=asc for the most negative topics, and frustration with sort_direction=desc for the most frustrated ones. Topics with no score are always ranked last.<br/>
        /// Default Value: conversations
        /// </param>
        /// <param name="sortDirection">
        /// Direction to sort topics.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="fromUnixSecs">
        /// Start of the window to view topics for. When set with to_unix_secs, the completed daily topic-discovery runs in the range are aggregated together, so the window scopes the metrics as well as the topic set. Floored to the start of its UTC day because runs cover whole UTC days; aggregated_run_count reports how many runs were summed. Omit both bounds to get the single latest run.
        /// </param>
        /// <param name="toUnixSecs">
        /// End of the window to view topics for.
        /// </param>
        /// <param name="includeEvaluationCriteria">
        /// Include the per-criteria evaluation breakdown on each topic's metrics. Pass false to drop it: it dominates the payload and the weighted success_rate is returned either way.<br/>
        /// Default Value: true
        /// </param> 
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.AgentTopicResponseModel> GetAutoPagingAsync(
            string agentId,             int? pageSize = default,
            global::ElevenLabs.TopicSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            int? fromUnixSecs = default,
            int? toUnixSecs = default,
            bool? includeEvaluationCriteria = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}