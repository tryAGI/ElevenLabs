#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete Phone Number<br/>
        /// Delete Phone Number by ID
        /// </summary>
        /// <param name="phoneNumberId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> Delete4Async(
            string phoneNumberId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}