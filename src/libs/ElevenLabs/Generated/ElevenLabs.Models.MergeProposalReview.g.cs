
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MergeProposalReview
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MergeProposalReviewStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.MergeProposalReviewState State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SubmittedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewer_role")]
        public global::ElevenLabs.MergeProposalReviewReviewerRole? ReviewerRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeProposalReview" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="state"></param>
        /// <param name="submittedAt"></param>
        /// <param name="comment"></param>
        /// <param name="reviewerRole"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MergeProposalReview(
            string userId,
            global::ElevenLabs.MergeProposalReviewState state,
            int submittedAt,
            string? comment,
            global::ElevenLabs.MergeProposalReviewReviewerRole? reviewerRole)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.State = state;
            this.SubmittedAt = submittedAt;
            this.Comment = comment;
            this.ReviewerRole = reviewerRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeProposalReview" /> class.
        /// </summary>
        public MergeProposalReview()
        {
        }

    }
}