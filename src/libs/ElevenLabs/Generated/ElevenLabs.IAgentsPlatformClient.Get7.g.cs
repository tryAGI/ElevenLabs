#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Phone Number<br/>
        /// Retrieve Phone Number details by ID
        /// </summary>
        /// <param name="phoneNumberId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetPhoneNumberRouteResponse> Get7Async(
            string phoneNumberId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}