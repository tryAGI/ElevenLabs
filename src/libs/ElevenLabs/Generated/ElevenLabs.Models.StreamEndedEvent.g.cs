
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StreamEndedEvent
    {
        /// <summary>
        /// Default Value: stream_ended
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_ended_event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.StreamEndedData StreamEndedEvent1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEndedEvent" /> class.
        /// </summary>
        /// <param name="streamEndedEvent1"></param>
        /// <param name="type">
        /// Default Value: stream_ended
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamEndedEvent(
            global::ElevenLabs.StreamEndedData streamEndedEvent1,
            string? type)
        {
            this.Type = type;
            this.StreamEndedEvent1 = streamEndedEvent1 ?? throw new global::System.ArgumentNullException(nameof(streamEndedEvent1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEndedEvent" /> class.
        /// </summary>
        public StreamEndedEvent()
        {
        }

    }
}