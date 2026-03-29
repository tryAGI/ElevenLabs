
#nullable enable

namespace ElevenLabs.Realtime
{
    /// <summary>
    /// Event containing a committed transcript with word-level timestamps.
    /// </summary>
    public sealed partial class CommittedTranscriptWithTimestampsPayload
    {
        /// <summary>
        /// Must be 'committed_transcript_with_timestamps'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.Realtime.JsonConverters.CommittedTranscriptWithTimestampsPayloadMessageTypeJsonConverter))]
        public global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// The committed transcript text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Detected language code, if language detection is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Word-level timing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.Realtime.TranscriptionWord>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommittedTranscriptWithTimestampsPayload" /> class.
        /// </summary>
        /// <param name="text">
        /// The committed transcript text.
        /// </param>
        /// <param name="messageType">
        /// Must be 'committed_transcript_with_timestamps'.
        /// </param>
        /// <param name="languageCode">
        /// Detected language code, if language detection is enabled.
        /// </param>
        /// <param name="words">
        /// Word-level timing information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommittedTranscriptWithTimestampsPayload(
            string text,
            global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayloadMessageType messageType,
            string? languageCode,
            global::System.Collections.Generic.IList<global::ElevenLabs.Realtime.TranscriptionWord>? words)
        {
            this.MessageType = messageType;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.LanguageCode = languageCode;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommittedTranscriptWithTimestampsPayload" /> class.
        /// </summary>
        public CommittedTranscriptWithTimestampsPayload()
        {
        }
    }
}