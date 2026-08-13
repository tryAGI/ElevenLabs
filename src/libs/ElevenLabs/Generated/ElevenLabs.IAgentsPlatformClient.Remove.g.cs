#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Remove Procedure<br/>
        /// Remove a procedure from the agent's draft working set.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RemoveAsync(
            string agentId,
            string branchId,
            string procedureId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Procedure<br/>
        /// Remove a procedure from the agent's draft working set.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<string>> RemoveAsResponseAsync(
            string agentId,
            string branchId,
            string procedureId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}