#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// Get Agent Response Test Summaries By Ids<br/>
        /// Gets multiple agent response tests by their IDs. Returns a dictionary mapping test IDs to test summaries.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetTestsSummariesByIdsResponseModel> SummariesAsync(

            global::ElevenLabs.ListTestsByIdsRequestModel request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Response Test Summaries By Ids<br/>
        /// Gets multiple agent response tests by their IDs. Returns a dictionary mapping test IDs to test summaries.
        /// </summary>
        /// <param name="testIds">
        /// List of test IDs to fetch. No duplicates allowed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetTestsSummariesByIdsResponseModel> SummariesAsync(
            global::System.Collections.Generic.IList<string> testIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}