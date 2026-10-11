
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TicketSearchMatchResponseModel
    {
        /// <summary>
        /// Which of the ticket's texts matched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TicketSearchMatchFieldJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TicketSearchMatchField Field { get; set; }

        /// <summary>
        /// Whitespace-collapsed excerpt around the match, with an ellipsis where it was cut.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Snippet { get; set; }

        /// <summary>
        /// Offset of the match in `snippet`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlight_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HighlightStart { get; set; }

        /// <summary>
        /// Exclusive end offset of the match in `snippet`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlight_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HighlightEnd { get; set; }

        /// <summary>
        /// The commented turn, set when `field` is 'turn_comment'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_index")]
        public int? TurnIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketSearchMatchResponseModel" /> class.
        /// </summary>
        /// <param name="field">
        /// Which of the ticket's texts matched.
        /// </param>
        /// <param name="snippet">
        /// Whitespace-collapsed excerpt around the match, with an ellipsis where it was cut.
        /// </param>
        /// <param name="highlightStart">
        /// Offset of the match in `snippet`.
        /// </param>
        /// <param name="highlightEnd">
        /// Exclusive end offset of the match in `snippet`.
        /// </param>
        /// <param name="turnIndex">
        /// The commented turn, set when `field` is 'turn_comment'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TicketSearchMatchResponseModel(
            global::ElevenLabs.TicketSearchMatchField field,
            string snippet,
            int highlightStart,
            int highlightEnd,
            int? turnIndex)
        {
            this.Field = field;
            this.Snippet = snippet ?? throw new global::System.ArgumentNullException(nameof(snippet));
            this.HighlightStart = highlightStart;
            this.HighlightEnd = highlightEnd;
            this.TurnIndex = turnIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketSearchMatchResponseModel" /> class.
        /// </summary>
        public TicketSearchMatchResponseModel()
        {
        }

    }
}