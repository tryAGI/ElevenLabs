#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Procedure Draft<br/>
        /// Create or update user's draft for a procedure
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.ProcedureDraftResponseModel> Update15Async(
            string agentId,
            string branchId,
            string procedureId,

            global::ElevenLabs.UpdateProcedureDraftRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Procedure Draft<br/>
        /// Create or update user's draft for a procedure
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ProcedureDraftResponseModel>> Update15AsResponseAsync(
            string agentId,
            string branchId,
            string procedureId,

            global::ElevenLabs.UpdateProcedureDraftRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Procedure Draft<br/>
        /// Create or update user's draft for a procedure
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
        /// <param name="name">
        /// Procedure name
        /// </param>
        /// <param name="content">
        /// Procedure content
        /// </param>
        /// <param name="type">
        /// Procedure type<br/>
        /// Default Value: free_form
        /// </param>
        /// <param name="trigger">
        /// When the agent should use this procedure. Empty string means this is a sub-procedure that should only start when another procedure references it. If omitted or null, the trigger is derived from the content instead. Also accepts `description` as an alias.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ProcedureDraftResponseModel> Update15Async(
            string agentId,
            string branchId,
            string procedureId,
            string name,
            string content,
            global::ElevenLabs.ProcedureType type = global::ElevenLabs.ProcedureType.FreeForm,
            string? trigger = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}