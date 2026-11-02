#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Analysis Item<br/>
        /// Update an analysis item. Publishes a new version when the content changes.
        /// </summary>
        /// <param name="analysisItemId">
        /// ID of the requested analysis item.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AnalysisItemResponseModel> Update7Async(
            string analysisItemId,

            global::ElevenLabs.AnyOf<global::ElevenLabs.UserEvaluationAnalysisItem, global::ElevenLabs.UserDataCollectionAnalysisItemInput> request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Analysis Item<br/>
        /// Update an analysis item. Publishes a new version when the content changes.
        /// </summary>
        /// <param name="analysisItemId">
        /// ID of the requested analysis item.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AnalysisItemResponseModel>> Update7AsResponseAsync(
            string analysisItemId,

            global::ElevenLabs.AnyOf<global::ElevenLabs.UserEvaluationAnalysisItem, global::ElevenLabs.UserDataCollectionAnalysisItemInput> request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Analysis Item<br/>
        /// Update an analysis item. Publishes a new version when the content changes.
        /// </summary>
        /// <param name="analysisItemId">
        /// ID of the requested analysis item.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AnalysisItemResponseModel> Update7Async(
            string analysisItemId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}