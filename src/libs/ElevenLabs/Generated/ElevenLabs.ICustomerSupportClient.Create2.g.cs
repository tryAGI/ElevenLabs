#nullable enable

namespace ElevenLabs
{
    public partial interface ICustomerSupportClient
    {
        /// <summary>
        /// Create Ticket Sla Policy<br/>
        /// Create a ticket SLA policy for the workspace. Requires support write permission.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.TicketSLAPolicyResponse> Create2Async(

            global::ElevenLabs.CreateTicketSLAPolicyRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Ticket Sla Policy<br/>
        /// Create a ticket SLA policy for the workspace. Requires support write permission.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.TicketSLAPolicyResponse>> Create2AsResponseAsync(

            global::ElevenLabs.CreateTicketSLAPolicyRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Ticket Sla Policy<br/>
        /// Create a ticket SLA policy for the workspace. Requires support write permission.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="targets"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.TicketSLAPolicyResponse> Create2Async(
            string name,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAPolicyTargetInput> targets,
            string? description = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}