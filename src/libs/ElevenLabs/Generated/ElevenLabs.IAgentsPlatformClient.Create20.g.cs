#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create A Merge Proposal<br/>
        /// Create a request to merge a source branch into a target branch. Callers with only propose access can open a proposal from a branch they own into its parent. Merging requires write access to the target branch.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentMergeProposalResponseModel> Create20Async(
            string agentId,

            global::ElevenLabs.BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create A Merge Proposal<br/>
        /// Create a request to merge a source branch into a target branch. Callers with only propose access can open a proposal from a branch they own into its parent. Merging requires write access to the target branch.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.CreateAgentMergeProposalResponseModel>> Create20AsResponseAsync(
            string agentId,

            global::ElevenLabs.BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create A Merge Proposal<br/>
        /// Create a request to merge a source branch into a target branch. Callers with only propose access can open a proposal from a branch they own into its parent. Merging requires write access to the target branch.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="sourceBranchId">
        /// Branch whose changes should be merged.
        /// </param>
        /// <param name="targetBranchId">
        /// Branch that should receive the changes.
        /// </param>
        /// <param name="title">
        /// Short title for the merge_proposal.
        /// </param>
        /// <param name="description">
        /// Optional longer description for reviewers.
        /// </param>
        /// <param name="requestedReviewerUserIds">
        /// User IDs to request a review from.
        /// </param>
        /// <param name="triageTicketId">
        /// Issue of this agent that the merge_proposal resolves. Merging it resolves the issue if still open.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentMergeProposalResponseModel> Create20Async(
            string agentId,
            string sourceBranchId,
            string targetBranchId,
            string title,
            string? description = default,
            global::System.Collections.Generic.IList<string>? requestedReviewerUserIds = default,
            string? triageTicketId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}