#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Preview Rebased Configuration<br/>
        /// Returns the result of rebasing the branch onto main without performing the rebase. Useful for showing an accurate diff before confirming.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// Unique identifier for the source branch to merge from.
        /// </param>
        /// <param name="includeProcedureGeneratedWorkflowElements">
        /// Whether to include the workflow nodes and edges generated from structured procedures. When false, the workflow contains only authored elements.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MergePreviewResponseModel> PreviewRebaseAsync(
            string agentId,
            string branchId,
            bool? includeProcedureGeneratedWorkflowElements = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Rebased Configuration<br/>
        /// Returns the result of rebasing the branch onto main without performing the rebase. Useful for showing an accurate diff before confirming.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// Unique identifier for the source branch to merge from.
        /// </param>
        /// <param name="includeProcedureGeneratedWorkflowElements">
        /// Whether to include the workflow nodes and edges generated from structured procedures. When false, the workflow contains only authored elements.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.MergePreviewResponseModel>> PreviewRebaseAsResponseAsync(
            string agentId,
            string branchId,
            bool? includeProcedureGeneratedWorkflowElements = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}