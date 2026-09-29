
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost
    {
        /// <summary>
        /// Branch whose changes should be merged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceBranchId { get; set; }

        /// <summary>
        /// Branch that should receive the changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetBranchId { get; set; }

        /// <summary>
        /// Short title for the merge_proposal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Optional longer description for reviewers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// User IDs to request a review from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_reviewer_user_ids")]
        public global::System.Collections.Generic.IList<string>? RequestedReviewerUserIds { get; set; }

        /// <summary>
        /// Triage ticket of this agent that the merge_proposal resolves. Merging it resolves the ticket if still open.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triage_ticket_id")]
        public string? TriageTicketId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost(
            string sourceBranchId,
            string targetBranchId,
            string title,
            string? description,
            global::System.Collections.Generic.IList<string>? requestedReviewerUserIds,
            string? triageTicketId)
        {
            this.SourceBranchId = sourceBranchId ?? throw new global::System.ArgumentNullException(nameof(sourceBranchId));
            this.TargetBranchId = targetBranchId ?? throw new global::System.ArgumentNullException(nameof(targetBranchId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description;
            this.RequestedReviewerUserIds = requestedReviewerUserIds;
            this.TriageTicketId = triageTicketId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost" /> class.
        /// </summary>
        public BodyCreateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsPost()
        {
        }

    }
}