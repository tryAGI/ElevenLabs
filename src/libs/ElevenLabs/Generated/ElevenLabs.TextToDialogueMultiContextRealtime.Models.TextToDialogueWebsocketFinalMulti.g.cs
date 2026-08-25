
#nullable enable

namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToDialogueWebsocketFinalMulti
    {
        /// <summary>
        /// Marks the end of this context's closing flush sequence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinal { get; set; }

        /// <summary>
        /// The context that has been finalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContextId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketFinalMulti" /> class.
        /// </summary>
        /// <param name="isFinal">
        /// Marks the end of this context's closing flush sequence.
        /// </param>
        /// <param name="contextId">
        /// The context that has been finalized.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToDialogueWebsocketFinalMulti(
            bool isFinal,
            string contextId)
        {
            this.IsFinal = isFinal;
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketFinalMulti" /> class.
        /// </summary>
        public TextToDialogueWebsocketFinalMulti()
        {
        }

    }
}