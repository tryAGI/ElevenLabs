#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Handle An Outbound Call Via Twilio<br/>
        /// Handle an outbound call via Twilio
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TwilioOutboundCallResponse> OutboundCallAsync(

            global::ElevenLabs.BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Handle An Outbound Call Via Twilio<br/>
        /// Handle an outbound call via Twilio
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.TwilioOutboundCallResponse>> OutboundCallAsResponseAsync(

            global::ElevenLabs.BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Handle An Outbound Call Via Twilio<br/>
        /// Handle an outbound call via Twilio
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="agentPhoneNumberId"></param>
        /// <param name="toNumber"></param>
        /// <param name="conversationInitiationClientData"></param>
        /// <param name="callRecordingEnabled">
        /// Whether let Twilio record the call.
        /// </param>
        /// <param name="telephonyCallConfig">
        /// Default Value: {"ringing_timeout_secs":60}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TwilioOutboundCallResponse> OutboundCallAsync(
            string agentId,
            string agentPhoneNumberId,
            string toNumber,
            global::ElevenLabs.ConversationInitiationClientDataRequestInput? conversationInitiationClientData = default,
            bool? callRecordingEnabled = default,
            global::ElevenLabs.TelephonyCallConfig? telephonyCallConfig = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}