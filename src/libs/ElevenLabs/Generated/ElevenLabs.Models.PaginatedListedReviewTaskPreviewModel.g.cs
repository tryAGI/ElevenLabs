
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedListedReviewTaskPreviewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ReviewTaskPreviewModel> ReviewTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedListedReviewTaskPreviewModel" /> class.
        /// </summary>
        /// <param name="reviewTasks"></param>
        /// <param name="cursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedListedReviewTaskPreviewModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReviewTaskPreviewModel> reviewTasks,
            string? cursor)
        {
            this.ReviewTasks = reviewTasks ?? throw new global::System.ArgumentNullException(nameof(reviewTasks));
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedListedReviewTaskPreviewModel" /> class.
        /// </summary>
        public PaginatedListedReviewTaskPreviewModel()
        {
        }
    }
}