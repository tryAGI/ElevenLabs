#nullable enable

namespace ElevenLabs
{
    public partial interface ICustomerSupportClient
    {
        /// <summary>
        /// Update Ticket Sla Policy<br/>
        /// Update a ticket SLA policy, including archiving or restoring it. Requires support write permission.
        /// </summary>
        /// <param name="policyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.TicketSLAPolicyResponse> Update2Async(
            string policyId,

            global::ElevenLabs.UpdateTicketSLAPolicyRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Ticket Sla Policy<br/>
        /// Update a ticket SLA policy, including archiving or restoring it. Requires support write permission.
        /// </summary>
        /// <param name="policyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.TicketSLAPolicyResponse>> Update2AsResponseAsync(
            string policyId,

            global::ElevenLabs.UpdateTicketSLAPolicyRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Ticket Sla Policy<br/>
        /// Update a ticket SLA policy, including archiving or restoring it. Requires support write permission.
        /// </summary>
        /// <param name="policyId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="targets"></param>
        /// <param name="archived"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.TicketSLAPolicyResponse> Update2Async(
            string policyId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAPolicyTargetInput>? targets = default,
            bool? archived = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}