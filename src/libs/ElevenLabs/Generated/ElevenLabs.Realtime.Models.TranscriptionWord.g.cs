
#nullable enable

namespace ElevenLabs.Realtime
{
    /// <summary>
    /// A word with timing information from a transcription.
    /// </summary>
    public sealed partial class TranscriptionWord
    {
        /// <summary>
        /// The word text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Start time in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// End time in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// Whether this element is a word or spacing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.Realtime.JsonConverters.TranscriptionWordTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Realtime.TranscriptionWordType Type { get; set; }

        /// <summary>
        /// Optional speaker identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_id")]
        public string? SpeakerId { get; set; }

        /// <summary>
        /// Optional log probability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        public double? Logprob { get; set; }

        /// <summary>
        /// Optional character-level breakdown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        public global::System.Collections.Generic.IList<string>? Characters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionWord" /> class.
        /// </summary>
        /// <param name="text">
        /// The word text.
        /// </param>
        /// <param name="start">
        /// Start time in seconds.
        /// </param>
        /// <param name="end">
        /// End time in seconds.
        /// </param>
        /// <param name="type">
        /// Whether this element is a word or spacing.
        /// </param>
        /// <param name="speakerId">
        /// Optional speaker identifier.
        /// </param>
        /// <param name="logprob">
        /// Optional log probability.
        /// </param>
        /// <param name="characters">
        /// Optional character-level breakdown.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionWord(
            string text,
            double start,
            double end,
            global::ElevenLabs.Realtime.TranscriptionWordType type,
            string? speakerId,
            double? logprob,
            global::System.Collections.Generic.IList<string>? characters)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
            this.Type = type;
            this.SpeakerId = speakerId;
            this.Logprob = logprob;
            this.Characters = characters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionWord" /> class.
        /// </summary>
        public TranscriptionWord()
        {
        }
    }
}