#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Submit A Batch Call Request.<br/>
        /// Submit a batch call request to schedule calls for multiple recipients.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.BatchCallResponse> Create8Async(

            global::ElevenLabs.BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit A Batch Call Request.<br/>
        /// Submit a batch call request to schedule calls for multiple recipients.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="callName"></param>
        /// <param name="agentId"></param>
        /// <param name="recipients"></param>
        /// <param name="scheduledTimeUnix"></param>
        /// <param name="agentPhoneNumberId"></param>
        /// <param name="whatsappParams"></param>
        /// <param name="timezone"></param>
        /// <param name="branchId"></param>
        /// <param name="environment"></param>
        /// <param name="telephonyCallConfig">
        /// Default Value: {"ringing_timeout_secs":60}
        /// </param>
        /// <param name="targetConcurrencyLimit">
        /// Maximum number of simultaneous calls for this batch. When set, dispatch is governed by this limit rather than workspace/agent capacity percentages.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.BatchCallResponse> Create8Async(
            string callName,
            string agentId,
            global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipient> recipients,
            string? xiApiKey = default,
            int? scheduledTimeUnix = default,
            string? agentPhoneNumberId = default,
            global::ElevenLabs.BatchCallWhatsAppParams? whatsappParams = default,
            string? timezone = default,
            string? branchId = default,
            string? environment = default,
            global::ElevenLabs.TelephonyCallConfig? telephonyCallConfig = default,
            int? targetConcurrencyLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}