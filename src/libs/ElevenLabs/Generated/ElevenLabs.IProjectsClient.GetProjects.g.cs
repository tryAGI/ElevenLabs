#nullable enable

namespace ElevenLabs
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get Projects<br/>
        /// Returns a list of your projects together and its metadata.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetProjectsResponseModel> GetProjectsAsync(
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}