#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Sip Messages For A Phone Number<br/>
        /// Get SIP messages for a phone number
        /// </summary>
        /// <param name="phoneNumberId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetSIPLogMessagesResponse> GetSipMessages2Async(
            string phoneNumberId,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Sip Messages For A Phone Number<br/>
        /// Get SIP messages for a phone number
        /// </summary>
        /// <param name="phoneNumberId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetSIPLogMessagesResponse>> GetSipMessages2AsResponseAsync(
            string phoneNumberId,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps GetSipMessages2Async as an IAsyncEnumerable&lt;global::ElevenLabs.SIPLogMessage&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="phoneNumberId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param> 
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.SIPLogMessage> GetSipMessages2AutoPagingAsync(
            string phoneNumberId,             int? pageSize = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}