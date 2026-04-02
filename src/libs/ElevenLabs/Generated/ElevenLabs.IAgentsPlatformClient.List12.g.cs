#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Whatsapp Accounts<br/>
        /// List all WhatsApp accounts
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ListWhatsAppAccountsResponse> List12Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}