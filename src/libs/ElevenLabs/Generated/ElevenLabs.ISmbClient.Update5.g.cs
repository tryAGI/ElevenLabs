#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Agent Procedure<br/>
        /// Replace an existing procedure on the named receptionist. Send every field: an omitted `body` resets to empty.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="procedureId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBProcedure> Update5Async(
            string agentId,
            string procedureId,

            global::ElevenLabs.BodySmbUpdateAgentProcedure request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Procedure<br/>
        /// Replace an existing procedure on the named receptionist. Send every field: an omitted `body` resets to empty.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="procedureId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SMBProcedure>> Update5AsResponseAsync(
            string agentId,
            string procedureId,

            global::ElevenLabs.BodySmbUpdateAgentProcedure request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Procedure<br/>
        /// Replace an existing procedure on the named receptionist. Send every field: an omitted `body` resets to empty.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="procedureId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request">
        /// Request model for updating an existing procedure.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBProcedure> Update5Async(
            string agentId,
            string procedureId,
            global::ElevenLabs.SMBUpdateProcedureRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}