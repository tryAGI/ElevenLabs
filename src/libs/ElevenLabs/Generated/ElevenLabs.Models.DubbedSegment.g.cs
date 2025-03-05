
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbedSegment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DubbingMediaReference MediaRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedSegment" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="text"></param>
        /// <param name="mediaRef"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbedSegment(
            double startTime,
            double endTime,
            string text,
            global::ElevenLabs.DubbingMediaReference mediaRef)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.MediaRef = mediaRef ?? throw new global::System.ArgumentNullException(nameof(mediaRef));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedSegment" /> class.
        /// </summary>
        public DubbedSegment()
        {
        }
    }
}