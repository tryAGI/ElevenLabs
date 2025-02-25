#nullable enable

namespace ElevenLabs
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Voices<br/>
        /// Gets a list of all available voices for a user.
        /// </summary>
        /// <param name="showLegacy">
        /// If set to true, legacy premade voices will be included in responses from /v1/voices<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetVoicesResponseModel> GetVoicesAsync(
            bool? showLegacy = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}