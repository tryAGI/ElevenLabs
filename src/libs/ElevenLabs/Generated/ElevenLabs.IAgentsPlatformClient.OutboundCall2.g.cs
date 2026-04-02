#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Make An Outbound Call Via Whatsapp<br/>
        /// Make an outbound call via WhatsApp
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WhatsAppOutboundCallResponse> OutboundCall2Async(

            global::ElevenLabs.BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Make An Outbound Call Via Whatsapp<br/>
        /// Make an outbound call via WhatsApp
        /// </summary>
        /// <param name="whatsappPhoneNumberId"></param>
        /// <param name="whatsappUserId"></param>
        /// <param name="whatsappCallPermissionRequestTemplateName"></param>
        /// <param name="whatsappCallPermissionRequestTemplateLanguageCode"></param>
        /// <param name="agentId"></param>
        /// <param name="conversationInitiationClientData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WhatsAppOutboundCallResponse> OutboundCall2Async(
            string whatsappPhoneNumberId,
            string whatsappUserId,
            string whatsappCallPermissionRequestTemplateName,
            string whatsappCallPermissionRequestTemplateLanguageCode,
            string agentId,
            global::ElevenLabs.ConversationInitiationClientDataRequestInput? conversationInitiationClientData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}