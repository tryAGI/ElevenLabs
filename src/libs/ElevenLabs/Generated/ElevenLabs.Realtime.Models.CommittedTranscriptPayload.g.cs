
#nullable enable

namespace ElevenLabs.Realtime
{
    /// <summary>
    /// Event containing a committed (final) transcript.
    /// </summary>
    public sealed partial class CommittedTranscriptPayload
    {
        /// <summary>
        /// Must be 'committed_transcript'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.Realtime.JsonConverters.CommittedTranscriptPayloadMessageTypeJsonConverter))]
        public global::ElevenLabs.Realtime.CommittedTranscriptPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// The committed transcript text.
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
        /// Initializes a new instance of the <see cref="CommittedTranscriptPayload" /> class.
        /// </summary>
        /// <param name="text">
        /// The committed transcript text.
        /// </param>
        /// <param name="messageType">
        /// Must be 'committed_transcript'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommittedTranscriptPayload(
            string text,
            global::ElevenLabs.Realtime.CommittedTranscriptPayloadMessageType messageType)
        {
            this.MessageType = messageType;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommittedTranscriptPayload" /> class.
        /// </summary>
        public CommittedTranscriptPayload()
        {
        }

    }
}