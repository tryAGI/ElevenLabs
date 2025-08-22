#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// Get Agent Response Test Summaries By Ids<br/>
        /// Gets multiple agent response tests by their IDs. Returns a dictionary mapping test IDs to test summaries.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetTestsSummariesByIdsResponseModel> CreateConvaiAgentTestingSummariesAsync(
            global::ElevenLabs.ListTestsByIdsRequestModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Agent Response Test Summaries By Ids<br/>
        /// Gets multiple agent response tests by their IDs. Returns a dictionary mapping test IDs to test summaries.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="testIds">
        /// List of test IDs to fetch. No duplicates allowed.<br/>
        /// Example: [test_id_1, test_id_2]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetTestsSummariesByIdsResponseModel> CreateConvaiAgentTestingSummariesAsync(
            global::System.Collections.Generic.IList<string> testIds,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}