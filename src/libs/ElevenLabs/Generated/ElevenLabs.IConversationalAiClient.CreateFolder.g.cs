#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAiClient
    {
        /// <summary>
        /// Create Folder<br/>
        /// Create a folder used for grouping documents together.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddKnowledgeBaseResponseModel> CreateFolderAsync(

            global::ElevenLabs.BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Folder<br/>
        /// Create a folder used for grouping documents together.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AddKnowledgeBaseResponseModel>> CreateFolderAsResponseAsync(

            global::ElevenLabs.BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Folder<br/>
        /// Create a folder used for grouping documents together.
        /// </summary>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        /// <param name="parentFolderId">
        /// If set, the created document or folder will be placed inside the given folder.
        /// </param>
        /// <param name="enableAutoSync">
        /// Whether to enable auto-sync for this URL document.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoRemove">
        /// Whether to automatically remove the document if the URL becomes unavailable. Only applicable when auto-sync is enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="minimumFrequencyDays">
        /// Minimum frequency (in days) at which the underlying eligible documents are refreshed. The actual interval may be shorter, never longer. Defaults to 7, tightened to the parent folder's frequency if that is stricter. Only applicable when auto-sync is enabled.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddKnowledgeBaseResponseModel> CreateFolderAsync(
            string name,
            string? parentFolderId = default,
            bool? enableAutoSync = default,
            bool? autoRemove = default,
            int? minimumFrequencyDays = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}