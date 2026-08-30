#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Procedures<br/>
        /// List the agent's procedures on a branch with their procedure_id, version_id, name, type, trigger, and has_draft. has_draft is true when a procedure has unpublished draft changes on this branch; its name/type/trigger then reflect that draft. Does not return procedure content -- use Get Procedure to read a procedure's body.
        /// </summary>
        /// <param name="agentId">
        /// Agent ID to get the procedure draft from
        /// </param>
        /// <param name="branchId">
        /// Branch ID to get the procedure draft from
        /// </param>
        /// <param name="agentVersionId">
        /// The agent version ID to retrieve the procedure for.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ListProceduresResponseModel> List16Async(
            string agentId,
            string branchId,
            string? agentVersionId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Procedures<br/>
        /// List the agent's procedures on a branch with their procedure_id, version_id, name, type, trigger, and has_draft. has_draft is true when a procedure has unpublished draft changes on this branch; its name/type/trigger then reflect that draft. Does not return procedure content -- use Get Procedure to read a procedure's body.
        /// </summary>
        /// <param name="agentId">
        /// Agent ID to get the procedure draft from
        /// </param>
        /// <param name="branchId">
        /// Branch ID to get the procedure draft from
        /// </param>
        /// <param name="agentVersionId">
        /// The agent version ID to retrieve the procedure for.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ListProceduresResponseModel>> List16AsResponseAsync(
            string agentId,
            string branchId,
            string? agentVersionId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}