#nullable enable

namespace ElevenLabs
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get User Info<br/>
        /// Gets information about the user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UserResponseModel> Get2Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}