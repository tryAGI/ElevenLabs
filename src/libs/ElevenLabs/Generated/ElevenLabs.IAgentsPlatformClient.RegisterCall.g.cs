#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Register A Twilio Call And Return Twiml<br/>
        /// Register a Twilio call and return TwiML to connect the call
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RegisterCallAsync(

            global::ElevenLabs.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register A Twilio Call And Return Twiml<br/>
        /// Register a Twilio call and return TwiML to connect the call
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="fromNumber"></param>
        /// <param name="toNumber"></param>
        /// <param name="direction">
        /// Default Value: inbound
        /// </param>
        /// <param name="conversationInitiationClientData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RegisterCallAsync(
            string agentId,
            string fromNumber,
            string toNumber,
            global::ElevenLabs.TelephonyDirection? direction = default,
            global::ElevenLabs.ConversationInitiationClientDataRequestInput? conversationInitiationClientData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}