
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A transcript produced by the optional transcript edit (text only, untimed).
    /// </summary>
    public sealed partial class EditedTranscript
    {
        /// <summary>
        /// Default Value: transcript
        /// </summary>
        /// <default>"transcript"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string Kind { get; set; } = "transcript";

        /// <summary>
        /// The edited transcript text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditedTranscript" /> class.
        /// </summary>
        /// <param name="text">
        /// The edited transcript text.
        /// </param>
        /// <param name="kind">
        /// Default Value: transcript
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditedTranscript(
            string text,
            string kind = "transcript")
        {
            this.Kind = kind;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditedTranscript" /> class.
        /// </summary>
        public EditedTranscript()
        {
        }

        /// <summary>
        /// Creates a new <see cref="EditedTranscript"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static EditedTranscript FromText(string text)
        {
            return new EditedTranscript
            {
                Text = text,
            };
        }

    }
}