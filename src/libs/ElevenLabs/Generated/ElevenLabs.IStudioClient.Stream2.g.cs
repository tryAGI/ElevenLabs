#nullable enable

namespace ElevenLabs
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Stream Chapter Audio<br/>
        /// Stream the audio from a chapter snapshot. Use `GET /v1/studio/projects/{project_id}/chapters/{chapter_id}/snapshots` to return the snapshots of a chapter.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="chapterId">
        /// The ID of the chapter.
        /// </param>
        /// <param name="chapterSnapshotId">
        /// The ID of the chapter snapshot.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> Stream2Async(
            string projectId,
            string chapterId,
            string chapterSnapshotId,

            global::ElevenLabs.BodyStreamChapterAudioV1StudioProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Chapter Audio<br/>
        /// Stream the audio from a chapter snapshot. Use `GET /v1/studio/projects/{project_id}/chapters/{chapter_id}/snapshots` to return the snapshots of a chapter.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="chapterId">
        /// The ID of the chapter.
        /// </param>
        /// <param name="chapterSnapshotId">
        /// The ID of the chapter snapshot.
        /// </param>
        /// <param name="convertToMpeg">
        /// Whether to convert the audio to mpeg format.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> Stream2Async(
            string projectId,
            string chapterId,
            string chapterSnapshotId,
            bool? convertToMpeg = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}