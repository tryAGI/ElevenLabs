
#nullable enable

namespace ElevenLabs.TextToDialogueRealtime
{
    /// <summary>
    /// Server chunk containing encoded audio and optional alignment metadata.
    /// </summary>
    public sealed partial class TextToDialogueWebsocketAudioChunk
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
        public global::ElevenLabs.TextToDialogueRealtime.DialogueTextAlignment? Alignment { get; set; }

        /// <summary>
        /// Reserved for future use; currently unused by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized_alignment")]
        public global::ElevenLabs.TextToDialogueRealtime.DialogueTextAlignment? NormalizedAlignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketAudioChunk" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded audio bytes for the selected `output_format`.
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
        public TextToDialogueWebsocketAudioChunk(
            string audio,
            global::ElevenLabs.TextToDialogueRealtime.DialogueTextAlignment? alignment,
            global::ElevenLabs.TextToDialogueRealtime.DialogueTextAlignment? normalizedAlignment)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Alignment = alignment;
            this.NormalizedAlignment = normalizedAlignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketAudioChunk" /> class.
        /// </summary>
        public TextToDialogueWebsocketAudioChunk()
        {
        }

    }
}