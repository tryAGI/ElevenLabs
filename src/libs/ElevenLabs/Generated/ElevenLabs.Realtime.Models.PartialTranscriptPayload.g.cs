
#nullable enable

namespace ElevenLabs.Realtime
{
    /// <summary>
    /// Event containing a partial (in-progress) transcript.
    /// </summary>
    public sealed partial class PartialTranscriptPayload
    {
        /// <summary>
        /// Must be 'partial_transcript'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.Realtime.JsonConverters.PartialTranscriptPayloadMessageTypeJsonConverter))]
        public global::ElevenLabs.Realtime.PartialTranscriptPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// The partial transcript text.
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
        /// Initializes a new instance of the <see cref="PartialTranscriptPayload" /> class.
        /// </summary>
        /// <param name="text">
        /// The partial transcript text.
        /// </param>
        /// <param name="messageType">
        /// Must be 'partial_transcript'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialTranscriptPayload(
            string text,
            global::ElevenLabs.Realtime.PartialTranscriptPayloadMessageType messageType)
        {
            this.MessageType = messageType;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTranscriptPayload" /> class.
        /// </summary>
        public PartialTranscriptPayload()
        {
        }
    }
}