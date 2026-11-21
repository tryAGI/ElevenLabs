#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Preview Merged Configuration<br/>
        /// Returns the result of merging the source branch into the target branch without performing the merge. When `conflicts` is not empty, the merge itself is rejected unless `conflict_resolutions` settles every conflict or `force` is set; until then the returned configuration shows one side of each conflict only as a placeholder.
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
        /// When true, the preview keeps the source branch's value for every conflict, as a merge with `force` does. Without it, a merge with conflicts needs `conflict_resolutions`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeProcedureGeneratedWorkflowElements">
        /// Whether to include the workflow nodes and edges generated from structured procedures. When false, the workflow contains only authored elements.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MergePreviewResponseModel> PreviewMergeAsync(
            string agentId,
            string sourceBranchId,
            string targetBranchId,
            bool? force = default,
            bool? includeProcedureGeneratedWorkflowElements = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Merged Configuration<br/>
        /// Returns the result of merging the source branch into the target branch without performing the merge. When `conflicts` is not empty, the merge itself is rejected unless `conflict_resolutions` settles every conflict or `force` is set; until then the returned configuration shows one side of each conflict only as a placeholder.
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
        /// When true, the preview keeps the source branch's value for every conflict, as a merge with `force` does. Without it, a merge with conflicts needs `conflict_resolutions`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeProcedureGeneratedWorkflowElements">
        /// Whether to include the workflow nodes and edges generated from structured procedures. When false, the workflow contains only authored elements.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.MergePreviewResponseModel>> PreviewMergeAsResponseAsync(
            string agentId,
            string sourceBranchId,
            string targetBranchId,
            bool? force = default,
            bool? includeProcedureGeneratedWorkflowElements = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}