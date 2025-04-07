#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Submit A Batch Call Request.<br/>
        /// Submit a batch call request to schedule calls for multiple recipients.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.BatchCallResponse> CreateConvaiBatchCallingSubmitAsync(
            global::ElevenLabs.BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Submit A Batch Call Request.<br/>
        /// Submit a batch call request to schedule calls for multiple recipients.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="callName"></param>
        /// <param name="agentId"></param>
        /// <param name="agentPhoneNumberId"></param>
        /// <param name="recipients"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.BatchCallResponse> CreateConvaiBatchCallingSubmitAsync(
            string callName,
            string agentId,
            string agentPhoneNumberId,
            global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipient> recipients,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}