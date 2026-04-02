#nullable enable

namespace ElevenLabs
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// List Voices<br/>
        /// Returns a list of all available voices for a user.
        /// </summary>
        /// <param name="showLegacy">
        /// If set to true, legacy premade voices will be included in responses from /v1/voices<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetVoicesResponseModel> GetAllAsync(
            bool? showLegacy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}