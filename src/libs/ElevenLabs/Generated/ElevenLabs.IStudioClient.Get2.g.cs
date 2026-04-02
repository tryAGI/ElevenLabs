#nullable enable

namespace ElevenLabs
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Get Project Snapshot<br/>
        /// Returns the project snapshot.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="projectSnapshotId">
        /// The ID of the Studio project snapshot.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ProjectSnapshotExtendedResponseModel> Get2Async(
            string projectId,
            string projectSnapshotId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}