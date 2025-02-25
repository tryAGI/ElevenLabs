#nullable enable

namespace ElevenLabs
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// List Chapters<br/>
        /// Returns a list of a Studio project's chapters.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetChaptersResponseModel> GetStudioProjectsByProjectIdChaptersAsync(
            string projectId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}