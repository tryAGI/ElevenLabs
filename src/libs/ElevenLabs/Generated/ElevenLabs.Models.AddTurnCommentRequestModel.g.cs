
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddTurnCommentRequestModel
    {
        /// <summary>
        /// Zero-based index of the transcript turn this comment refers to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TurnIndex { get; set; }

        /// <summary>
        /// What went wrong at this turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTurnCommentRequestModel" /> class.
        /// </summary>
        /// <param name="turnIndex">
        /// Zero-based index of the transcript turn this comment refers to.
        /// </param>
        /// <param name="comment">
        /// What went wrong at this turn.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddTurnCommentRequestModel(
            int turnIndex,
            string comment)
        {
            this.TurnIndex = turnIndex;
            this.Comment = comment ?? throw new global::System.ArgumentNullException(nameof(comment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTurnCommentRequestModel" /> class.
        /// </summary>
        public AddTurnCommentRequestModel()
        {
        }

    }
}