#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Procedure<br/>
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBProcedure> Update7Async(
            string agentId,
            string procedureId,

            global::ElevenLabs.SMBUpdateProcedureRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Procedure<br/>
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SMBProcedure>> Update7AsResponseAsync(
            string agentId,
            string procedureId,

            global::ElevenLabs.SMBUpdateProcedureRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Procedure<br/>
        /// Replace an existing procedure on the named receptionist. Send every field: an omitted `body` resets to empty.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="procedureId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="name">
        /// Name of the procedure.
        /// </param>
        /// <param name="trigger">
        /// When the receptionist should run the procedure, in natural language. The receptionist matches caller requests against it, e.g. 'When the caller wants to book an appointment'.
        /// </param>
        /// <param name="body">
        /// Step-by-step instructions, as markdown.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBProcedure> Update7Async(
            string agentId,
            string procedureId,
            string name,
            string trigger,
            string? xiWorkspaceId = default,
            string? body = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}