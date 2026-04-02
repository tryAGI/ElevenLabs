#nullable enable

namespace ElevenLabs
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Get Chapter<br/>
        /// Returns information about a specific chapter.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="chapterId">
        /// The ID of the chapter.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ChapterWithContentResponseModel> Get3Async(
            string projectId,
            string chapterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}