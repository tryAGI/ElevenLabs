#nullable enable

namespace ElevenLabs
{
    public partial interface ICustomerSupportClient
    {
        /// <summary>
        /// Create Ticket<br/>
        /// Create ticket
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetTicketResponse> Create3Async(

            global::ElevenLabs.CreateTicketRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Ticket<br/>
        /// Create ticket
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetTicketResponse>> Create3AsResponseAsync(

            global::ElevenLabs.CreateTicketRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Ticket<br/>
        /// Create ticket
        /// </summary>
        /// <param name="requester"></param>
        /// <param name="author"></param>
        /// <param name="subject"></param>
        /// <param name="description"></param>
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetTicketResponse> Create3Async(
            global::ElevenLabs.Requester requester,
            global::ElevenLabs.Author author,
            string subject,
            string? description = default,
            global::ElevenLabs.TicketPriority? priority = default,
            int? deadlineAtUnixSecs = default,
            global::System.Collections.Generic.IList<string>? tagIds = default,
            global::ElevenLabs.AssigneeVariant12? assignee = default,
            global::ElevenLabs.SecondaryAssigneeVariant12? secondaryAssignee = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSubscriberRequest>? subscribers = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}