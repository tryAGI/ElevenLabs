
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingSourceTranscriptResponse
    {
        /// <summary>
        /// BCP-47 language tag of the source transcript (null if unknown).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The source segments, in playback order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptSegment> Segments { get; set; }

        /// <summary>
        /// The project's source-transcript revision at read time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingSourceTranscriptResponse" /> class.
        /// </summary>
        /// <param name="segments">
        /// The source segments, in playback order.
        /// </param>
        /// <param name="revision">
        /// The project's source-transcript revision at read time.
        /// </param>
        /// <param name="language">
        /// BCP-47 language tag of the source transcript (null if unknown).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingSourceTranscriptResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptSegment> segments,
            int revision,
            string? language)
        {
            this.Language = language;
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingSourceTranscriptResponse" /> class.
        /// </summary>
        public DubbingSourceTranscriptResponse()
        {
        }

    }
}