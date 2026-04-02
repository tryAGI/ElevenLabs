#nullable enable

namespace ElevenLabs
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Stream Archive With Studio Project Audio<br/>
        /// Returns a compressed archive of the Studio project's audio.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="projectSnapshotId">
        /// The ID of the Studio project snapshot.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamArchiveAsync(
            string projectId,
            string projectSnapshotId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}