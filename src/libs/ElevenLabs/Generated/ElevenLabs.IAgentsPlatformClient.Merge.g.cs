#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Merge A Branch Into A Target Branch<br/>
        /// Merge a branch into a target branch. If both branches changed the same field, the merge returns 409 unless `conflict_resolutions` settles every conflict the merge preview reports, or `force` is set.
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MergeAsync(
            string agentId,
            string sourceBranchId,
            string targetBranchId,

            global::ElevenLabs.BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Merge A Branch Into A Target Branch<br/>
        /// Merge a branch into a target branch. If both branches changed the same field, the merge returns 409 unless `conflict_resolutions` settles every conflict the merge preview reports, or `force` is set.
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<string>> MergeAsResponseAsync(
            string agentId,
            string sourceBranchId,
            string targetBranchId,

            global::ElevenLabs.BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Merge A Branch Into A Target Branch<br/>
        /// Merge a branch into a target branch. If both branches changed the same field, the merge returns 409 unless `conflict_resolutions` settles every conflict the merge preview reports, or `force` is set.
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
        /// <param name="archiveSourceBranch">
        /// Whether to archive the source branch after merging<br/>
        /// Default Value: true
        /// </param>
        /// <param name="force">
        /// Keep the source branch's value for every conflict instead of sending `conflict_resolutions`<br/>
        /// Default Value: false
        /// </param>
        /// <param name="conflictResolutions">
        /// Side to keep, or custom text where the conflict accepts it, for each conflict the preview reported. A merge or rebase with conflicts is rejected unless there is one for every conflict, sent with both tip ids. On a merge it can't be combined with `force`, which lets the source win every conflict instead.
        /// </param>
        /// <param name="sourceTipId">
        /// Source branch tip version the conflicts were resolved against (`source_tip_version_id` of the preview). The request fails with 409 if the branch moved since.
        /// </param>
        /// <param name="targetTipId">
        /// Target branch tip version the conflicts were resolved against (`target_tip_version_id` of the preview). The request fails with 409 if the branch moved since.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> MergeAsync(
            string agentId,
            string sourceBranchId,
            string targetBranchId,
            bool? archiveSourceBranch = default,
            bool? force = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ConflictResolution>? conflictResolutions = default,
            string? sourceTipId = default,
            string? targetTipId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}