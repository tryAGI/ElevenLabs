#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// Update Agent Response Test<br/>
        /// Updates an agent response test by ID.
        /// </summary>
        /// <param name="testId">
        /// The id of a chat response test. This is returned on test creation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpdateAgentResponseTestRouteResponse> UpdateAsync(
            string testId,

            global::ElevenLabs.AnyOf<global::ElevenLabs.UpdateResponseUnitTestRequest, global::ElevenLabs.UpdateToolCallUnitTestRequest, global::ElevenLabs.UpdateSimulationTestRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Response Test<br/>
        /// Updates an agent response test by ID.
        /// </summary>
        /// <param name="testId">
        /// The id of a chat response test. This is returned on test creation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpdateAgentResponseTestRouteResponse> UpdateAsync(
            string testId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}