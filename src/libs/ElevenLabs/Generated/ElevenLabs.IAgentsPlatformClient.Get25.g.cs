#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Procedure<br/>
        /// Retrieve a procedure at a specific version or the current branch HEAD.
        /// </summary>
        /// <param name="agentId">
        /// Agent ID to get the procedure draft from
        /// </param>
        /// <param name="branchId">
        /// Branch ID to get the procedure draft from
        /// </param>
        /// <param name="procedureId">
        /// The procedure ID
        /// </param>
        /// <param name="versionId">
        /// The version ID to retrieve. If omitted, returns the version at branch HEAD.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ProcedureAtVersionResponseModel> Get25Async(
            string agentId,
            string branchId,
            string procedureId,
            string? versionId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Procedure<br/>
        /// Retrieve a procedure at a specific version or the current branch HEAD.
        /// </summary>
        /// <param name="agentId">
        /// Agent ID to get the procedure draft from
        /// </param>
        /// <param name="branchId">
        /// Branch ID to get the procedure draft from
        /// </param>
        /// <param name="procedureId">
        /// The procedure ID
        /// </param>
        /// <param name="versionId">
        /// The version ID to retrieve. If omitted, returns the version at branch HEAD.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ProcedureAtVersionResponseModel>> Get25AsResponseAsync(
            string agentId,
            string branchId,
            string procedureId,
            string? versionId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}