#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechToTextEvaluationClient
    {
        /// <summary>
        /// List Evaluations
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="evalCriterionId"></param>
        /// <param name="status"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="search"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortDir"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PaginatedEvaluationResponse> GetSpeechToTextEvaluationEvaluationsAsync(
            string? agentId = default,
            string? evalCriterionId = default,
            string? status = default,
            string? createdAfter = default,
            string? createdBefore = default,
            string? search = default,
            string? sortBy = default,
            string? sortDir = default,
            int? pageSize = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}