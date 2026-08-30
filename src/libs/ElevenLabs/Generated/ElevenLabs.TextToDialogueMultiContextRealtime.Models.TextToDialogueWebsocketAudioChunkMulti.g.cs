
#nullable enable

namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    /// <summary>
    /// Server chunk containing encoded audio for a specific context and optional alignment metadata.
    /// </summary>
    public sealed partial class TextToDialogueWebsocketAudioChunkMulti
    {
        /// <summary>
        /// Base64-encoded audio bytes for the selected `output_format`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// Present when sync_alignment is true and timing data is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.DialogueTextAlignment? Alignment { get; set; }

        /// <summary>
        /// Reserved for future use; currently unused by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized_alignment")]
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.DialogueTextAlignment? NormalizedAlignment { get; set; }

        /// <summary>
        /// The context this audio chunk belongs to.
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
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketAudioChunkMulti" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded audio bytes for the selected `output_format`.
        /// </param>
        /// <param name="contextId">
        /// The context this audio chunk belongs to.
        /// </param>
        /// <param name="alignment">
        /// Present when sync_alignment is true and timing data is available.
        /// </param>
        /// <param name="normalizedAlignment">
        /// Reserved for future use; currently unused by the server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToDialogueWebsocketAudioChunkMulti(
            string audio,
            string contextId,
            global::ElevenLabs.TextToDialogueMultiContextRealtime.DialogueTextAlignment? alignment,
            global::ElevenLabs.TextToDialogueMultiContextRealtime.DialogueTextAlignment? normalizedAlignment)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Alignment = alignment;
            this.NormalizedAlignment = normalizedAlignment;
            this.ContextId = contextId ?? throw new global::System.ArgumentNullException(nameof(contextId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketAudioChunkMulti" /> class.
        /// </summary>
        public TextToDialogueWebsocketAudioChunkMulti()
        {
        }

    }
}