#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Whatsapp Account<br/>
        /// Get a WhatsApp account
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetWhatsAppAccountResponse> Get18Async(
            string phoneNumberId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}