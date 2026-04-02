#nullable enable

namespace ElevenLabs
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Convert Studio Project<br/>
        /// Starts conversion of a Studio project and all of its chapters.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConvertProjectResponseModel> ConvertAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}