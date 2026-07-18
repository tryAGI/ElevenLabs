
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Metadata about the project's source media.
    /// </summary>
    public sealed partial class DubbingSourceMediaInfo
    {
        /// <summary>
        /// Original filename of the uploaded source media (null for URL sources).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Duration of the source media in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_s")]
        public double? DurationS { get; set; }

        /// <summary>
        /// Whether the source media contains a video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_video")]
        public bool? HasVideo { get; set; }

        /// <summary>
        /// MIME type of the uploaded source media.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingSourceMediaInfo" /> class.
        /// </summary>
        /// <param name="filename">
        /// Original filename of the uploaded source media (null for URL sources).
        /// </param>
        /// <param name="durationS">
        /// Duration of the source media in seconds.
        /// </param>
        /// <param name="hasVideo">
        /// Whether the source media contains a video stream.
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the uploaded source media.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingSourceMediaInfo(
            string? filename,
            double? durationS,
            bool? hasVideo,
            string? mimeType)
        {
            this.Filename = filename;
            this.DurationS = durationS;
            this.HasVideo = hasVideo;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingSourceMediaInfo" /> class.
        /// </summary>
        public DubbingSourceMediaInfo()
        {
        }

    }
}