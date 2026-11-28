#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Agent Branch<br/>
        /// Update agent branch properties such as name, description, archiving status, protection level, auto-rebase, and the branch it is kept in sync with
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// Unique identifier for the branch.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentBranchResponse> Update15Async(
            string agentId,
            string branchId,

            global::ElevenLabs.BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Branch<br/>
        /// Update agent branch properties such as name, description, archiving status, protection level, auto-rebase, and the branch it is kept in sync with
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// Unique identifier for the branch.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AgentBranchResponse>> Update15AsResponseAsync(
            string agentId,
            string branchId,

            global::ElevenLabs.BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Branch<br/>
        /// Update agent branch properties such as name, description, archiving status, protection level, auto-rebase, and the branch it is kept in sync with
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// Unique identifier for the branch.
        /// </param>
        /// <param name="name">
        /// New name for the branch. Must be unique within the agent.
        /// </param>
        /// <param name="description">
        /// New description for the branch. Pass an empty string to clear it.
        /// </param>
        /// <param name="isArchived">
        /// Whether the branch should be archived
        /// </param>
        /// <param name="protectionStatus">
        /// The protection level for the branch
        /// </param>
        /// <param name="autoRebase">
        /// When true, rebase this branch automatically after each new version of the branch it is kept in sync with (`sync_branch_id`, main by default). Cannot be enabled on the main branch, or while this branch is more protected than a non-main branch it is kept in sync with.
        /// </param>
        /// <param name="syncBranchId">
        /// ID of the branch to keep this branch in sync with: its new versions are pulled in automatically while `auto_rebase` is on. Pass the main branch's ID to sync with main again. Must be the main branch or the active branch this branch was created from (`parent_branch_id`). At most 10 branches can be kept in sync with one another in a row. Cannot be set on the main branch.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentBranchResponse> Update15Async(
            string agentId,
            string branchId,
            string? name = default,
            string? description = default,
            bool? isArchived = default,
            global::ElevenLabs.BranchProtectionStatus? protectionStatus = default,
            bool? autoRebase = default,
            string? syncBranchId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}