#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Procedure Visibility<br/>
        /// Update or clear the visibility of a procedure draft. This is the condition that controls if a procedure is visible to the agent in its procedure menu.
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ProcedureDraftResponseModel> UpdateVisibilityAsync(
            string agentId,
            string branchId,
            string procedureId,

            global::ElevenLabs.UpdateProcedureVisibilityRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Procedure Visibility<br/>
        /// Update or clear the visibility of a procedure draft. This is the condition that controls if a procedure is visible to the agent in its procedure menu.
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ProcedureDraftResponseModel>> UpdateVisibilityAsResponseAsync(
            string agentId,
            string branchId,
            string procedureId,

            global::ElevenLabs.UpdateProcedureVisibilityRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Procedure Visibility<br/>
        /// Update or clear the visibility of a procedure draft. This is the condition that controls if a procedure is visible to the agent in its procedure menu.
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
        /// <param name="visibility">
        /// The condition that controls if the procedure is visible to the agent in its procedure menu. Null clears it, so the procedure is always visible.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ProcedureDraftResponseModel> UpdateVisibilityAsync(
            string agentId,
            string branchId,
            string procedureId,
            global::ElevenLabs.ProcedureVisibilityInput? visibility = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}