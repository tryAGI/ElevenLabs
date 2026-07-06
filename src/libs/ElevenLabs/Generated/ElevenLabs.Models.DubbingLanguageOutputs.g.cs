
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Signed, time-limited download URLs for a language target's outputs.
    /// </summary>
    public sealed partial class DubbingLanguageOutputs
    {
        /// <summary>
        /// Signed URL of the dubbed lossless audio track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lossless_audio")]
        public string? LosslessAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingLanguageOutputs" /> class.
        /// </summary>
        /// <param name="losslessAudio">
        /// Signed URL of the dubbed lossless audio track.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingLanguageOutputs(
            string? losslessAudio)
        {
            this.LosslessAudio = losslessAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingLanguageOutputs" /> class.
        /// </summary>
        public DubbingLanguageOutputs()
        {
        }

    }
}