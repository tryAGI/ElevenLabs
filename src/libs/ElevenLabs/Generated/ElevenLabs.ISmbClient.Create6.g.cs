#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Add Procedure<br/>
        /// Add a procedure (SOP) to the named receptionist.
        /// </summary>
        /// <param name="agentId">
        /// ID of the receptionist. List them with `GET /v1/reception/customer-facing-agents`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionProcedure> Create6Async(
            string agentId,
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionCreateProcedureRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Procedure<br/>
        /// Add a procedure (SOP) to the named receptionist.
        /// </summary>
        /// <param name="agentId">
        /// ID of the receptionist. List them with `GET /v1/reception/customer-facing-agents`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ReceptionProcedure>> Create6AsResponseAsync(
            string agentId,
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionCreateProcedureRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Procedure<br/>
        /// Add a procedure (SOP) to the named receptionist.
        /// </summary>
        /// <param name="agentId">
        /// ID of the receptionist. List them with `GET /v1/reception/customer-facing-agents`.
        /// </param>
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionProcedure> Create6Async(
            string agentId,
            string xiWorkspaceId,
            string name,
            string trigger,
            string? body = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}