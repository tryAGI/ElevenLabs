
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocxExportOptions
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_speakers")]
        public bool? IncludeSpeakers { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_timestamps")]
        public bool? IncludeTimestamps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.DocxExportOptionsFormatJsonConverter))]
        public global::ElevenLabs.DocxExportOptionsFormat Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_on_silence_longer_than_s")]
        public double? SegmentOnSilenceLongerThanS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_segment_duration_s")]
        public double? MaxSegmentDurationS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_segment_chars")]
        public int? MaxSegmentChars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocxExportOptions" /> class.
        /// </summary>
        /// <param name="includeSpeakers">
        /// Default Value: true
        /// </param>
        /// <param name="includeTimestamps">
        /// Default Value: true
        /// </param>
        /// <param name="format"></param>
        /// <param name="segmentOnSilenceLongerThanS"></param>
        /// <param name="maxSegmentDurationS"></param>
        /// <param name="maxSegmentChars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocxExportOptions(
            bool? includeSpeakers,
            bool? includeTimestamps,
            global::ElevenLabs.DocxExportOptionsFormat format,
            double? segmentOnSilenceLongerThanS,
            double? maxSegmentDurationS,
            int? maxSegmentChars)
        {
            this.IncludeSpeakers = includeSpeakers;
            this.IncludeTimestamps = includeTimestamps;
            this.Format = format;
            this.SegmentOnSilenceLongerThanS = segmentOnSilenceLongerThanS;
            this.MaxSegmentDurationS = maxSegmentDurationS;
            this.MaxSegmentChars = maxSegmentChars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocxExportOptions" /> class.
        /// </summary>
        public DocxExportOptions()
        {
        }
    }
}