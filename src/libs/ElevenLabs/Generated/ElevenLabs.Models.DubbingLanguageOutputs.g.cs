
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Signed, time-limited download URLs for a language target's outputs.
    /// </summary>
    public sealed partial class DubbingLanguageOutputs
    {
        /// <summary>
        /// Signed URL for the dubbed lossless audio track, in FLAC. The link expires one hour after it is issued; re-read the language target for a fresh one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lossless_audio")]
        public string? LosslessAudio { get; set; }

        /// <summary>
        /// Signed URL for the translated lines as WebVTT subtitles, timed to the source speech. Null when none are available, such as for languages dubbed before subtitles were produced. The link expires one hour after it is issued.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitles")]
        public string? Subtitles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingLanguageOutputs" /> class.
        /// </summary>
        /// <param name="losslessAudio">
        /// Signed URL for the dubbed lossless audio track, in FLAC. The link expires one hour after it is issued; re-read the language target for a fresh one.
        /// </param>
        /// <param name="subtitles">
        /// Signed URL for the translated lines as WebVTT subtitles, timed to the source speech. Null when none are available, such as for languages dubbed before subtitles were produced. The link expires one hour after it is issued.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingLanguageOutputs(
            string? losslessAudio,
            string? subtitles)
        {
            this.LosslessAudio = losslessAudio;
            this.Subtitles = subtitles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingLanguageOutputs" /> class.
        /// </summary>
        public DubbingLanguageOutputs()
        {
        }

    }
}