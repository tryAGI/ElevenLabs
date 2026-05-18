
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"max_chars_per_line":42,"max_duration_ms":7000,"max_lines_per_cue":2,"min_duration_ms":1000}
    /// </summary>
    public sealed partial class CueOptionsRequest
    {
        /// <summary>
        /// Minimum duration of each cue in milliseconds.<br/>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_duration_ms")]
        public int? MinDurationMs { get; set; }

        /// <summary>
        /// Maximum duration of each cue in milliseconds.<br/>
        /// Default Value: 7000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration_ms")]
        public int? MaxDurationMs { get; set; }

        /// <summary>
        /// Maximum number of lines per cue.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_lines_per_cue")]
        public int? MaxLinesPerCue { get; set; }

        /// <summary>
        /// Maximum number of characters per line in a cue.<br/>
        /// Default Value: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_chars_per_line")]
        public int? MaxCharsPerLine { get; set; }

        /// <summary>
        /// Maximum characters per second reading speed. If not set, no reading speed limit is applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_chars_per_s")]
        public int? MaxCharsPerS { get; set; }

        /// <summary>
        /// Minimum gap between consecutive cues in frames. If not set, no minimum gap is enforced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_gap_between_cues_frames")]
        public int? MinGapBetweenCuesFrames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CueOptionsRequest" /> class.
        /// </summary>
        /// <param name="minDurationMs">
        /// Minimum duration of each cue in milliseconds.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="maxDurationMs">
        /// Maximum duration of each cue in milliseconds.<br/>
        /// Default Value: 7000
        /// </param>
        /// <param name="maxLinesPerCue">
        /// Maximum number of lines per cue.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="maxCharsPerLine">
        /// Maximum number of characters per line in a cue.<br/>
        /// Default Value: 42
        /// </param>
        /// <param name="maxCharsPerS">
        /// Maximum characters per second reading speed. If not set, no reading speed limit is applied.
        /// </param>
        /// <param name="minGapBetweenCuesFrames">
        /// Minimum gap between consecutive cues in frames. If not set, no minimum gap is enforced.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CueOptionsRequest(
            int? minDurationMs,
            int? maxDurationMs,
            int? maxLinesPerCue,
            int? maxCharsPerLine,
            int? maxCharsPerS,
            int? minGapBetweenCuesFrames)
        {
            this.MinDurationMs = minDurationMs;
            this.MaxDurationMs = maxDurationMs;
            this.MaxLinesPerCue = maxLinesPerCue;
            this.MaxCharsPerLine = maxCharsPerLine;
            this.MaxCharsPerS = maxCharsPerS;
            this.MinGapBetweenCuesFrames = minGapBetweenCuesFrames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CueOptionsRequest" /> class.
        /// </summary>
        public CueOptionsRequest()
        {
        }

    }
}