#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete Whatsapp Account<br/>
        /// Delete a WhatsApp account
        /// </summary>
        /// <param name="phoneNumberId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> Delete12Async(
            string phoneNumberId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}