
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentMergeProposalResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceBranchId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetBranchId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_tip_version_id_at_creation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceTipVersionIdAtCreation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_reviewer_user_ids")]
        public global::System.Collections.Generic.IList<string>? RequestedReviewerUserIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviews")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalReview>? Reviews { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalComment>? Comments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.OutcomeJsonConverter))]
        public global::ElevenLabs.Outcome? Outcome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAt { get; set; }

        /// <summary>
        /// User ID of the merge_proposal's author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_user_id")]
        public string? AuthorUserId { get; set; }

        /// <summary>
        /// Access information for the merge_proposal, including creator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        public global::ElevenLabs.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMergeProposalResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId"></param>
        /// <param name="sourceBranchId"></param>
        /// <param name="targetBranchId"></param>
        /// <param name="sourceTipVersionIdAtCreation"></param>
        /// <param name="title"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
        /// <param name="requestedReviewerUserIds"></param>
        /// <param name="reviews"></param>
        /// <param name="comments"></param>
        /// <param name="outcome"></param>
        /// <param name="authorUserId">
        /// User ID of the merge_proposal's author.
        /// </param>
        /// <param name="accessInfo">
        /// Access information for the merge_proposal, including creator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMergeProposalResponse(
            string id,
            string agentId,
            string sourceBranchId,
            string targetBranchId,
            string sourceTipVersionIdAtCreation,
            string title,
            int createdAt,
            int updatedAt,
            string? description,
            global::System.Collections.Generic.IList<string>? requestedReviewerUserIds,
            global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalReview>? reviews,
            global::System.Collections.Generic.IList<global::ElevenLabs.MergeProposalComment>? comments,
            global::ElevenLabs.Outcome? outcome,
            string? authorUserId,
            global::ElevenLabs.ResourceAccessInfo? accessInfo)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.SourceBranchId = sourceBranchId ?? throw new global::System.ArgumentNullException(nameof(sourceBranchId));
            this.TargetBranchId = targetBranchId ?? throw new global::System.ArgumentNullException(nameof(targetBranchId));
            this.SourceTipVersionIdAtCreation = sourceTipVersionIdAtCreation ?? throw new global::System.ArgumentNullException(nameof(sourceTipVersionIdAtCreation));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description;
            this.RequestedReviewerUserIds = requestedReviewerUserIds;
            this.Reviews = reviews;
            this.Comments = comments;
            this.Outcome = outcome;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AuthorUserId = authorUserId;
            this.AccessInfo = accessInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMergeProposalResponse" /> class.
        /// </summary>
        public AgentMergeProposalResponse()
        {
        }

    }
}