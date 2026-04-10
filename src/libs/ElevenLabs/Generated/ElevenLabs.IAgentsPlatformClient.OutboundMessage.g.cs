#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Send An Outbound Message Via Whatsapp<br/>
        /// Send an outbound message via WhatsApp
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WhatsAppOutboundMessageResponse> OutboundMessageAsync(

            global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send An Outbound Message Via Whatsapp<br/>
        /// Send an outbound message via WhatsApp
        /// </summary>
        /// <param name="whatsappPhoneNumberId"></param>
        /// <param name="whatsappUserId"></param>
        /// <param name="templateName"></param>
        /// <param name="templateLanguageCode"></param>
        /// <param name="templateParams"></param>
        /// <param name="agentId"></param>
        /// <param name="conversationInitiationClientData"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WhatsAppOutboundMessageResponse> OutboundMessageAsync(
            string whatsappPhoneNumberId,
            string whatsappUserId,
            string templateName,
            string templateLanguageCode,
            global::System.Collections.Generic.IList<global::ElevenLabs.TemplateParamsItem> templateParams,
            string agentId,
            global::ElevenLabs.ConversationInitiationClientDataRequestInput? conversationInitiationClientData = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}