
#nullable enable

namespace ElevenLabs.TextToDialogueRealtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToDialogueWebsocketFinalAudioForTurn
    {
        /// <summary>
        /// Indicates that the final audio for a given turn has been sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final_audio_for_turn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinalAudioForTurn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketFinalAudioForTurn" /> class.
        /// </summary>
        /// <param name="isFinalAudioForTurn">
        /// Indicates that the final audio for a given turn has been sent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToDialogueWebsocketFinalAudioForTurn(
            bool isFinalAudioForTurn)
        {
            this.IsFinalAudioForTurn = isFinalAudioForTurn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketFinalAudioForTurn" /> class.
        /// </summary>
        public TextToDialogueWebsocketFinalAudioForTurn()
        {
        }

    }
}