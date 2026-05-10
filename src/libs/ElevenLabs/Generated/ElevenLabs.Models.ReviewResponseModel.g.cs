
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReviewResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ReviewResponseModelReviewStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReviewResponseModelReviewStatus ReviewStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewed_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReviewedAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewed_by")]
        public string? ReviewedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reject_reasons")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>? RejectReasons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores_breakdown")]
        public global::System.Collections.Generic.Dictionary<string, int>? ScoresBreakdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected_details")]
        public string? RejectedDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explanation")]
        public string? Explanation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewResponseModel" /> class.
        /// </summary>
        /// <param name="reviewStatus"></param>
        /// <param name="reviewedAtUnix"></param>
        /// <param name="reviewedBy"></param>
        /// <param name="rejectReasons"></param>
        /// <param name="scoresBreakdown"></param>
        /// <param name="rejectedDetails"></param>
        /// <param name="explanation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewResponseModel(
            global::ElevenLabs.ReviewResponseModelReviewStatus reviewStatus,
            int reviewedAtUnix,
            string? reviewedBy,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReviewResponseModelRejectReasonsVariant1Item>? rejectReasons,
            global::System.Collections.Generic.Dictionary<string, int>? scoresBreakdown,
            string? rejectedDetails,
            string? explanation)
        {
            this.ReviewStatus = reviewStatus;
            this.ReviewedAtUnix = reviewedAtUnix;
            this.ReviewedBy = reviewedBy;
            this.RejectReasons = rejectReasons;
            this.ScoresBreakdown = scoresBreakdown;
            this.RejectedDetails = rejectedDetails;
            this.Explanation = explanation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewResponseModel" /> class.
        /// </summary>
        public ReviewResponseModel()
        {
        }

    }
}