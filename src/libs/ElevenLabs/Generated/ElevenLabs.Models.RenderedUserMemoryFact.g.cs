
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RenderedUserMemoryFact
    {
        /// <summary>
        /// ID of the fact, to delete it on its own.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// What the fact is about, e.g. `diet`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Attribute { get; set; }

        /// <summary>
        /// The fact itself, e.g. `Is vegetarian.`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// When it became true, or for an event when it happened.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_from")]
        public global::System.DateTime? ValidFrom { get; set; }

        /// <summary>
        /// When it stopped being true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_to")]
        public global::System.DateTime? ValidTo { get; set; }

        /// <summary>
        /// When agents learned it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learned_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LearnedAtUnixSecs { get; set; }

        /// <summary>
        /// When agents stopped believing it. Unset while still believed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalidated_at_unix_secs")]
        public int? InvalidatedAtUnixSecs { get; set; }

        /// <summary>
        /// How many times the user has said it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReferenceCount { get; set; }

        /// <summary>
        /// The latest conversation in which the user said it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen_conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastSeenConversationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderedUserMemoryFact" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the fact, to delete it on its own.
        /// </param>
        /// <param name="attribute">
        /// What the fact is about, e.g. `diet`.
        /// </param>
        /// <param name="text">
        /// The fact itself, e.g. `Is vegetarian.`
        /// </param>
        /// <param name="learnedAtUnixSecs">
        /// When agents learned it.
        /// </param>
        /// <param name="referenceCount">
        /// How many times the user has said it.
        /// </param>
        /// <param name="lastSeenConversationId">
        /// The latest conversation in which the user said it.
        /// </param>
        /// <param name="validFrom">
        /// When it became true, or for an event when it happened.
        /// </param>
        /// <param name="validTo">
        /// When it stopped being true.
        /// </param>
        /// <param name="invalidatedAtUnixSecs">
        /// When agents stopped believing it. Unset while still believed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenderedUserMemoryFact(
            string id,
            string attribute,
            string text,
            int learnedAtUnixSecs,
            int referenceCount,
            string lastSeenConversationId,
            global::System.DateTime? validFrom,
            global::System.DateTime? validTo,
            int? invalidatedAtUnixSecs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Attribute = attribute ?? throw new global::System.ArgumentNullException(nameof(attribute));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.ValidFrom = validFrom;
            this.ValidTo = validTo;
            this.LearnedAtUnixSecs = learnedAtUnixSecs;
            this.InvalidatedAtUnixSecs = invalidatedAtUnixSecs;
            this.ReferenceCount = referenceCount;
            this.LastSeenConversationId = lastSeenConversationId ?? throw new global::System.ArgumentNullException(nameof(lastSeenConversationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderedUserMemoryFact" /> class.
        /// </summary>
        public RenderedUserMemoryFact()
        {
        }

    }
}