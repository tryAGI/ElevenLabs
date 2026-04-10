#nullable enable

namespace ElevenLabs
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Update Chapter<br/>
        /// Updates a chapter.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="chapterId">
        /// The ID of the chapter.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EditChapterResponseModel> Update3Async(
            string projectId,
            string chapterId,

            global::ElevenLabs.BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Chapter<br/>
        /// Updates a chapter.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="chapterId">
        /// The ID of the chapter.
        /// </param>
        /// <param name="name">
        /// The name of the chapter, used for identification only.
        /// </param>
        /// <param name="content">
        /// The chapter content to use.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EditChapterResponseModel> Update3Async(
            string projectId,
            string chapterId,
            string? name = default,
            global::ElevenLabs.ChapterContentInputModel? content = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}