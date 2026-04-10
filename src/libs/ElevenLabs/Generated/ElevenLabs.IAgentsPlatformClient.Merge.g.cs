#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Merge A Branch Into A Target Branch<br/>
        /// Merge a branch into a target branch
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
        /// Merge a branch into a target branch
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
        /// Force source branch changes onto the target, overriding timestamp-based conflict resolution<br/>
        /// Default Value: false
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
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}