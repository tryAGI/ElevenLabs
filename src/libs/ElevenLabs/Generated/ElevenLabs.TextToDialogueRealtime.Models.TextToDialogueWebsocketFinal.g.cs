
#nullable enable

namespace ElevenLabs.TextToDialogueRealtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToDialogueWebsocketFinal
    {
        /// <summary>
        /// Marks the end of the closing flush sequence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketFinal" /> class.
        /// </summary>
        /// <param name="isFinal">
        /// Marks the end of the closing flush sequence.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToDialogueWebsocketFinal(
            bool isFinal)
        {
            this.IsFinal = isFinal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToDialogueWebsocketFinal" /> class.
        /// </summary>
        public TextToDialogueWebsocketFinal()
        {
        }

    }
}