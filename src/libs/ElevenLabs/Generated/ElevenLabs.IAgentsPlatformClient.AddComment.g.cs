#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Comment On A Merge Proposal<br/>
        /// Leave a comment on a merge_proposal without recording a review verdict. Unlike reviews, comments accumulate and can still be added once the merge_proposal is merged or closed.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="mergeProposalId">
        /// Unique identifier for the merge_proposal.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentMergeProposalResponse> AddCommentAsync(
            string agentId,
            string mergeProposalId,

            global::ElevenLabs.BodyCommentOnAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdCommentsPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Comment On A Merge Proposal<br/>
        /// Leave a comment on a merge_proposal without recording a review verdict. Unlike reviews, comments accumulate and can still be added once the merge_proposal is merged or closed.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="mergeProposalId">
        /// Unique identifier for the merge_proposal.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AgentMergeProposalResponse>> AddCommentAsResponseAsync(
            string agentId,
            string mergeProposalId,

            global::ElevenLabs.BodyCommentOnAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdCommentsPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Comment On A Merge Proposal<br/>
        /// Leave a comment on a merge_proposal without recording a review verdict. Unlike reviews, comments accumulate and can still be added once the merge_proposal is merged or closed.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="mergeProposalId">
        /// Unique identifier for the merge_proposal.
        /// </param>
        /// <param name="body">
        /// The comment text. Markdown is supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentMergeProposalResponse> AddCommentAsync(
            string agentId,
            string mergeProposalId,
            string body,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}