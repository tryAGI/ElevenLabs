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
        /// The ID of the Studio project.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetChaptersResponseModel> List3Async(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}