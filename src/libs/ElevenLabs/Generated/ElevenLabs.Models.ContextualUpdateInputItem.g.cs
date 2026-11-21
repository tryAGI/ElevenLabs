
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContextualUpdateInputItem
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"contextual_update"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "contextual_update";

        /// <summary>
        /// Context for the agent that the user did not write, such as the client's current state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// What the update describes. The agent sees only the latest update for each `context_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContextId { get; set; }

        /// <summary>
        /// `in_place`: the update stays where it was sent, like an event. `end`: the update is current state, sent after the newest message or tool result.<br/>
        /// Default Value: in_place
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ContextualUpdatePlacementJsonConverter))]
        public global::ElevenLabs.ContextualUpdatePlacement? Placement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextualUpdateInputItem" /> class.
        /// </summary>
        /// <param name="text">
        /// Context for the agent that the user did not write, such as the client's current state.
        /// </param>
        /// <param name="contextId">
        /// What the update describes. The agent sees only the latest update for each `context_id`.
        /// </param>
        /// <param name="placement">
        /// `in_place`: the update stays where it was sent, like an event. `end`: the update is current state, sent after the newest message or tool result.<br/>
        /// Default Value: in_place
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextualUpdateInputItem(
            string text,
            string contextId,
            global::ElevenLabs.ContextualUpdatePlacement? placement,
            string type = "contextual_update")
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
            this.Placement = placement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextualUpdateInputItem" /> class.
        /// </summary>
        public ContextualUpdateInputItem()
        {
        }

    }
}