#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Preview Merged Configuration<br/>
        /// Returns the result of merging the source branch into the target branch without performing the merge. Useful for showing an accurate diff before confirming.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="sourceBranchId">
        /// Unique identifier for the source branch to merge from.
        /// </param>
        /// <param name="targetBranchId">
        /// The ID of the target branch to merge into.
        /// </param>
        /// <param name="force">
        /// When true, source branch changes always win conflicts regardless of timestamps<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MergePreviewResponseModel> PreviewMergeAsync(
            string agentId,
            string sourceBranchId,
            string targetBranchId,
            bool? force = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Merged Configuration<br/>
        /// Returns the result of merging the source branch into the target branch without performing the merge. Useful for showing an accurate diff before confirming.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="sourceBranchId">
        /// Unique identifier for the source branch to merge from.
        /// </param>
        /// <param name="targetBranchId">
        /// The ID of the target branch to merge into.
        /// </param>
        /// <param name="force">
        /// When true, source branch changes always win conflicts regardless of timestamps<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.MergePreviewResponseModel>> PreviewMergeAsResponseAsync(
            string agentId,
            string sourceBranchId,
            string targetBranchId,
            bool? force = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}