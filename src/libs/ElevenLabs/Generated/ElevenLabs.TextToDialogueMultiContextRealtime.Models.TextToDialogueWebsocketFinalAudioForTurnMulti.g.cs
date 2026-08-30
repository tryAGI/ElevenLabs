
#nullable enable

namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextToDialogueWebsocketFinalAudioForTurnMulti
    {
        /// <summary>
        /// Indicates that the final audio for a given turn of this context has been sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final_audio_for_turn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinalAudioForTurn { get; set; }

        /// <summary>
        /// The context whose turn has finished.
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
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketFinalAudioForTurnMulti" /> class.
        /// </summary>
        /// <param name="isFinalAudioForTurn">
        /// Indicates that the final audio for a given turn of this context has been sent.
        /// </param>
        /// <param name="contextId">
        /// The context whose turn has finished.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToDialogueWebsocketFinalAudioForTurnMulti(
            bool isFinalAudioForTurn,
            string contextId)
        {
            this.IsFinalAudioForTurn = isFinalAudioForTurn;
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketFinalAudioForTurnMulti" /> class.
        /// </summary>
        public TextToDialogueWebsocketFinalAudioForTurnMulti()
        {
        }

    }
}