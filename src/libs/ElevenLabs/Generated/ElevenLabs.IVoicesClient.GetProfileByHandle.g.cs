#nullable enable

namespace ElevenLabs
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get A Profile Page<br/>
        /// Gets a profile page based on a handle
        /// </summary>
        /// <param name="handle">
        /// Handle for a VA's profile page<br/>
        /// Example: talexgeorge
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ProfilePageResponseModel> GetProfileByHandleAsync(
            string handle,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}