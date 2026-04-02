#nullable enable

namespace ElevenLabs
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Stream Studio Project Audio<br/>
        /// Stream the audio from a Studio project snapshot.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="projectSnapshotId">
        /// The ID of the Studio project snapshot.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamAsync(
            string projectId,
            string projectSnapshotId,

            global::ElevenLabs.BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Studio Project Audio<br/>
        /// Stream the audio from a Studio project snapshot.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="projectSnapshotId">
        /// The ID of the Studio project snapshot.
        /// </param>
        /// <param name="convertToMpeg">
        /// Whether to convert the audio to mpeg format.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamAsync(
            string projectId,
            string projectSnapshotId,
            bool? convertToMpeg = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}