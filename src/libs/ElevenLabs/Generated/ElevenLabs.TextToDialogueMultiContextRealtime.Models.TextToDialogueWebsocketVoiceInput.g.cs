
#nullable enable

namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextToDialogueWebsocketVoiceInput
    {
        /// <summary>
        /// Text appended for this voice. Buffered with prior text until the server triggers generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Must be one of the IDs from the initial `voices` array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// When `true`, the server finalizes the current pending segment (as if the speaker finished their turn) before applying this input.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_turn")]
        public bool? NewTurn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketVoiceInput" /> class.
        /// </summary>
        /// <param name="text">
        /// Text appended for this voice. Buffered with prior text until the server triggers generation.
        /// </param>
        /// <param name="voiceId">
        /// Must be one of the IDs from the initial `voices` array.
        /// </param>
        /// <param name="newTurn">
        /// When `true`, the server finalizes the current pending segment (as if the speaker finished their turn) before applying this input.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToDialogueWebsocketVoiceInput(
            string text,
            string voiceId,
            bool? newTurn)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.NewTurn = newTurn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketVoiceInput" /> class.
        /// </summary>
        public TextToDialogueWebsocketVoiceInput()
        {
        }

    }
}