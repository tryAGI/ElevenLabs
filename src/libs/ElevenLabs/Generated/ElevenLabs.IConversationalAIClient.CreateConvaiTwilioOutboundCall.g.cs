#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Handle An Outbound Call Via Twilio<br/>
        /// Handle an outbound call via Twilio
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TwilioOutboundCallResponse> CreateConvaiTwilioOutboundCallAsync(
            global::ElevenLabs.BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Handle An Outbound Call Via Twilio<br/>
        /// Handle an outbound call via Twilio
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="agentPhoneNumberId"></param>
        /// <param name="toNumber"></param>
        /// <param name="conversationInitiationClientData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TwilioOutboundCallResponse> CreateConvaiTwilioOutboundCallAsync(
            string agentId,
            string agentPhoneNumberId,
            string toNumber,
            string? xiApiKey = default,
            global::ElevenLabs.ConversationInitiationClientDataRequestInput? conversationInitiationClientData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}