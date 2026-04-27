#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Tool Executions<br/>
        /// Get paginated list of tool executions for a specific tool.
        /// </summary>
        /// <param name="toolId">
        /// ID of the requested tool.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="isError">
        /// Filter by error status. If not provided, returns all executions.
        /// </param>
        /// <param name="agentId">
        /// Filter by agent ID.
        /// </param>
        /// <param name="branchId">
        /// Filter by agent branch ID.
        /// </param>
        /// <param name="startTime">
        /// Filter executions from this Unix timestamp (inclusive).
        /// </param>
        /// <param name="endTime">
        /// Filter executions until this Unix timestamp (inclusive).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetToolExecutionsPageResponseModel> Get15Async(
            string toolId,
            string? cursor = default,
            int? pageSize = default,
            bool? isError = default,
            string? agentId = default,
            string? branchId = default,
            double? startTime = default,
            double? endTime = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}