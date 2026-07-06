
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingTargetTranscriptResponse
    {
        /// <summary>
        /// BCP-47 language tag of the source transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        public string? SourceLanguage { get; set; }

        /// <summary>
        /// BCP-47 language tag this target is translated into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetLanguage { get; set; }

        /// <summary>
        /// The target segments, in playback order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTargetTranscriptSegment> Segments { get; set; }

        /// <summary>
        /// The target's revision at read time.
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
        /// Initializes a new instance of the <see cref="DubbingTargetTranscriptResponse" /> class.
        /// </summary>
        /// <param name="targetLanguage">
        /// BCP-47 language tag this target is translated into.
        /// </param>
        /// <param name="segments">
        /// The target segments, in playback order.
        /// </param>
        /// <param name="revision">
        /// The target's revision at read time.
        /// </param>
        /// <param name="sourceLanguage">
        /// BCP-47 language tag of the source transcript.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingTargetTranscriptResponse(
            string targetLanguage,
            global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTargetTranscriptSegment> segments,
            int revision,
            string? sourceLanguage)
        {
            this.SourceLanguage = sourceLanguage;
            this.TargetLanguage = targetLanguage ?? throw new global::System.ArgumentNullException(nameof(targetLanguage));
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTargetTranscriptResponse" /> class.
        /// </summary>
        public DubbingTargetTranscriptResponse()
        {
        }

    }
}