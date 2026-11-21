#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Rebase A Branch Onto Main<br/>
        /// Pull changes from a source branch (defaults to main) into this branch as a new version. If both branches changed the same field, the rebase returns 409 unless `conflict_resolutions` settles every conflict the rebase preview reports.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// Unique identifier for the source branch to merge from.
        /// </param>
        /// <param name="sourceBranchId">
        /// The ID of the branch to pull changes from. Defaults to the agent's main branch.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RebaseAsync(
            string agentId,
            string branchId,

            global::ElevenLabs.BodyRebaseABranchOntoMainV1ConvaiAgentsAgentIdBranchesBranchIdRebasePost request,
            string? sourceBranchId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rebase A Branch Onto Main<br/>
        /// Pull changes from a source branch (defaults to main) into this branch as a new version. If both branches changed the same field, the rebase returns 409 unless `conflict_resolutions` settles every conflict the rebase preview reports.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// Unique identifier for the source branch to merge from.
        /// </param>
        /// <param name="sourceBranchId">
        /// The ID of the branch to pull changes from. Defaults to the agent's main branch.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<string>> RebaseAsResponseAsync(
            string agentId,
            string branchId,

            global::ElevenLabs.BodyRebaseABranchOntoMainV1ConvaiAgentsAgentIdBranchesBranchIdRebasePost request,
            string? sourceBranchId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rebase A Branch Onto Main<br/>
        /// Pull changes from a source branch (defaults to main) into this branch as a new version. If both branches changed the same field, the rebase returns 409 unless `conflict_resolutions` settles every conflict the rebase preview reports.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// Unique identifier for the source branch to merge from.
        /// </param>
        /// <param name="sourceBranchId">
        /// The ID of the branch to pull changes from. Defaults to the agent's main branch.
        /// </param>
        /// <param name="conflictResolutions">
        /// Side to keep, or custom text where the conflict accepts it, for each conflict the preview reported. A merge or rebase with conflicts is rejected unless there is one for every conflict, sent with both tip ids. On a merge it can't be combined with `force`, which lets the source win every conflict instead.
        /// </param>
        /// <param name="branchTipId">
        /// Tip version of the branch being rebased (`source_tip_version_id` of the rebase preview) the conflicts were resolved against. The request fails with 409 if it moved since.
        /// </param>
        /// <param name="sourceTipId">
        /// Tip version of the branch the changes are pulled from (`source_branch_id`, the main branch by default; `target_tip_version_id` of the rebase preview) the conflicts were resolved against. The request fails with 409 if it moved since.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RebaseAsync(
            string agentId,
            string branchId,
            string? sourceBranchId = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ConflictResolution>? conflictResolutions = default,
            string? branchTipId = default,
            string? sourceTipId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}