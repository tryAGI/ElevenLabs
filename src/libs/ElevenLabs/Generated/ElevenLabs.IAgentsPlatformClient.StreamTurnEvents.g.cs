#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Stream Conversation Turn Events<br/>
        /// Stream the events of a turn as server-sent events. Send `Last-Event-ID` to resume after an event. The server keeps events for about an hour. This endpoint is in alpha and may change.
        /// </summary>
        /// <param name="conversationId">
        /// The Conversation ID
        /// </param>
        /// <param name="turnId">
        /// The Turn ID
        /// </param>
        /// <param name="lastEventId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.StreamEnvelope> StreamTurnEventsAsync(
            string conversationId,
            string turnId,
            string? lastEventId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}