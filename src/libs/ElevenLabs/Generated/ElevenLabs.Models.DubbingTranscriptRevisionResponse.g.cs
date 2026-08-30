
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The new revision after a source edit that returns no segment (e.g. a delete).
    /// </summary>
    public sealed partial class DubbingTranscriptRevisionResponse
    {
        /// <summary>
        /// The project's source-transcript revision after this edit.
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
        /// Initializes a new instance of the <see cref="DubbingTranscriptRevisionResponse" /> class.
        /// </summary>
        /// <param name="revision">
        /// The project's source-transcript revision after this edit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingTranscriptRevisionResponse(
            int revision)
        {
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscriptRevisionResponse" /> class.
        /// </summary>
        public DubbingTranscriptRevisionResponse()
        {
        }

    }
}