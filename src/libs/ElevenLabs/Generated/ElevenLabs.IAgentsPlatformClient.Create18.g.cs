#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create A Merge Proposal<br/>
        /// Record a request to merge a source branch into a target branch. Anyone with edit access can open one; merging it later is gated on write access to the target branch, so this is how a change reaches a protected branch the author cannot merge into themselves.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentMergeProposalResponseModel> Create18Async(
            string agentId,

            global::ElevenLabs.BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create A Merge Proposal<br/>
        /// Record a request to merge a source branch into a target branch. Anyone with edit access can open one; merging it later is gated on write access to the target branch, so this is how a change reaches a protected branch the author cannot merge into themselves.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.CreateAgentMergeProposalResponseModel>> Create18AsResponseAsync(
            string agentId,

            global::ElevenLabs.BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create A Merge Proposal<br/>
        /// Record a request to merge a source branch into a target branch. Anyone with edit access can open one; merging it later is gated on write access to the target branch, so this is how a change reaches a protected branch the author cannot merge into themselves.
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
        /// Triage ticket of this agent that the merge_proposal resolves. Merging it resolves the ticket if still open.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentMergeProposalResponseModel> Create18Async(
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