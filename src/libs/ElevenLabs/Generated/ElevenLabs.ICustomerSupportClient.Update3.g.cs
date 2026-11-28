#nullable enable

namespace ElevenLabs
{
    public partial interface ICustomerSupportClient
    {
        /// <summary>
        /// Update Ticket<br/>
        /// Update ticket
        /// </summary>
        /// <param name="ticketId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetTicketResponse> Update3Async(
            string ticketId,

            global::ElevenLabs.UpdateTicketRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Ticket<br/>
        /// Update ticket
        /// </summary>
        /// <param name="ticketId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetTicketResponse>> Update3AsResponseAsync(
            string ticketId,

            global::ElevenLabs.UpdateTicketRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Ticket<br/>
        /// Update ticket
        /// </summary>
        /// <param name="ticketId"></param>
        /// <param name="subject"></param>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        /// <param name="deadlineAtUnixSecs"></param>
        /// <param name="tagIds"></param>
        /// <param name="assignee"></param>
        /// <param name="secondaryAssignee"></param>
        /// <param name="subscribers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetTicketResponse> Update3Async(
            string ticketId,
            string? subject = default,
            global::ElevenLabs.TicketStatus? status = default,
            global::ElevenLabs.TicketPriority? priority = default,
            int? deadlineAtUnixSecs = default,
            global::System.Collections.Generic.IList<string>? tagIds = default,
            global::ElevenLabs.AssigneeVariant13? assignee = default,
            global::ElevenLabs.SecondaryAssigneeVariant13? secondaryAssignee = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSubscriberRequest>? subscribers = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}