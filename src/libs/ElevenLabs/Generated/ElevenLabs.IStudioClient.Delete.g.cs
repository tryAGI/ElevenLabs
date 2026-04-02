#nullable enable

namespace ElevenLabs
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Delete Studio Project<br/>
        /// Deletes a Studio project.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DeleteProjectResponseModel> DeleteAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}