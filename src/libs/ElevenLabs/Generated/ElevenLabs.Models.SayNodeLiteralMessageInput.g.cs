
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SayNodeLiteralMessageInput
    {
        /// <summary>
        /// Default Value: literal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Literal text message to be spoken by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Translations for the text field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_translations")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TranslatedString>? TextTranslations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SayNodeLiteralMessageInput" /> class.
        /// </summary>
        /// <param name="text">
        /// Literal text message to be spoken by the agent.
        /// </param>
        /// <param name="type">
        /// Default Value: literal
        /// </param>
        /// <param name="textTranslations">
        /// Translations for the text field
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SayNodeLiteralMessageInput(
            string text,
            string? type,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TranslatedString>? textTranslations)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.TextTranslations = textTranslations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SayNodeLiteralMessageInput" /> class.
        /// </summary>
        public SayNodeLiteralMessageInput()
        {
        }

    }
}