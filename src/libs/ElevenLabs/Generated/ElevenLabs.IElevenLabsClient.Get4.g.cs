#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// Get Agent Response Test By Id<br/>
        /// Gets an agent response test by ID.
        /// </summary>
        /// <param name="testId">
        /// The id of a chat response test. This is returned on test creation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentResponseTestRouteResponse> Get4Async(
            string testId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}