#nullable enable

namespace ElevenLabs
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Convert Chapter<br/>
        /// Starts conversion of a specific chapter.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="chapterId">
        /// The ID of the chapter.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConvertChapterResponseModel> Convert2Async(
            string projectId,
            string chapterId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}