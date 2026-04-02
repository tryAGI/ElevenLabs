#nullable enable

namespace ElevenLabs
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// List Studio Projects<br/>
        /// Returns a list of your Studio projects with metadata.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetProjectsResponseModel> ListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}