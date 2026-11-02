#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Analysis Item Attachments<br/>
        /// Attach or detach one analysis item on multiple agent branches.
        /// </summary>
        /// <param name="analysisItemId">
        /// ID of the requested analysis item.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModel> UpdateAttachmentsAsync(
            string analysisItemId,

            global::ElevenLabs.UpdateAnalysisItemAttachmentsRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Analysis Item Attachments<br/>
        /// Attach or detach one analysis item on multiple agent branches.
        /// </summary>
        /// <param name="analysisItemId">
        /// ID of the requested analysis item.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModel>> UpdateAttachmentsAsResponseAsync(
            string analysisItemId,

            global::ElevenLabs.UpdateAnalysisItemAttachmentsRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Analysis Item Attachments<br/>
        /// Attach or detach one analysis item on multiple agent branches.
        /// </summary>
        /// <param name="analysisItemId">
        /// ID of the requested analysis item.
        /// </param>
        /// <param name="source"></param>
        /// <param name="attach"></param>
        /// <param name="detach"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModel> UpdateAttachmentsAsync(
            string analysisItemId,
            global::ElevenLabs.AnalysisItemSource source,
            global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemAttachmentDestination>? attach = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemAttachmentDestination>? detach = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}