
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyUpdateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdPatch
    {
        /// <summary>
        /// New title for the merge_proposal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// New description for the merge_proposal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Replacement list of user IDs to request a review from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_reviewer_user_ids")]
        public global::System.Collections.Generic.IList<string>? RequestedReviewerUserIds { get; set; }

        /// <summary>
        /// When true, close the merge_proposal without merging.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("close")]
        public bool? Close { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdPatch" /> class.
        /// </summary>
        /// <param name="title">
        /// New title for the merge_proposal.
        /// </param>
        /// <param name="description">
        /// New description for the merge_proposal.
        /// </param>
        /// <param name="requestedReviewerUserIds">
        /// Replacement list of user IDs to request a review from.
        /// </param>
        /// <param name="close">
        /// When true, close the merge_proposal without merging.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdPatch(
            string? title,
            string? description,
            global::System.Collections.Generic.IList<string>? requestedReviewerUserIds,
            bool? close)
        {
            this.Title = title;
            this.Description = description;
            this.RequestedReviewerUserIds = requestedReviewerUserIds;
            this.Close = close;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdPatch" /> class.
        /// </summary>
        public BodyUpdateAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdPatch()
        {
        }

    }
}