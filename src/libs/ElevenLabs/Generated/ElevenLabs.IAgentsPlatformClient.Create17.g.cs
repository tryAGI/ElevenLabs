#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create Procedure<br/>
        /// Create a new procedure for the agent on a branch.
        /// </summary>
        /// <param name="agentId">
        /// Agent ID to get the procedure draft from
        /// </param>
        /// <param name="branchId">
        /// Branch ID to get the procedure draft from
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateProcedureResponseModel> Create17Async(
            string agentId,
            string branchId,

            global::ElevenLabs.CreateProcedureRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Procedure<br/>
        /// Create a new procedure for the agent on a branch.
        /// </summary>
        /// <param name="agentId">
        /// Agent ID to get the procedure draft from
        /// </param>
        /// <param name="branchId">
        /// Branch ID to get the procedure draft from
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.CreateProcedureResponseModel>> Create17AsResponseAsync(
            string agentId,
            string branchId,

            global::ElevenLabs.CreateProcedureRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Procedure<br/>
        /// Create a new procedure for the agent on a branch.
        /// </summary>
        /// <param name="agentId">
        /// Agent ID to get the procedure draft from
        /// </param>
        /// <param name="branchId">
        /// Branch ID to get the procedure draft from
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateProcedureResponseModel> Create17Async(
            string agentId,
            string branchId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}