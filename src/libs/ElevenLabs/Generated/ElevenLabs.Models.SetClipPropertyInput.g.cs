
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetClipPropertyInput
    {
        /// <summary>
        /// ID of the composition node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Zero-based index of the track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrackIndex { get; set; }

        /// <summary>
        /// Zero-based index of the clip within the track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClipIndex { get; set; }

        /// <summary>
        /// Silence in seconds before this clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gap_before")]
        public double? GapBefore { get; set; }

        /// <summary>
        /// Start time in seconds to trim from source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_in")]
        public double? TrimIn { get; set; }

        /// <summary>
        /// End time in seconds to trim to in source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_out")]
        public double? TrimOut { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetClipPropertyInput" /> class.
        /// </summary>
        /// <param name="nodeId">
        /// ID of the composition node.
        /// </param>
        /// <param name="trackIndex">
        /// Zero-based index of the track.
        /// </param>
        /// <param name="clipIndex">
        /// Zero-based index of the clip within the track.
        /// </param>
        /// <param name="gapBefore">
        /// Silence in seconds before this clip.
        /// </param>
        /// <param name="trimIn">
        /// Start time in seconds to trim from source.
        /// </param>
        /// <param name="trimOut">
        /// End time in seconds to trim to in source.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetClipPropertyInput(
            string nodeId,
            int trackIndex,
            int clipIndex,
            double? gapBefore,
            double? trimIn,
            double? trimOut)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.TrackIndex = trackIndex;
            this.ClipIndex = clipIndex;
            this.GapBefore = gapBefore;
            this.TrimIn = trimIn;
            this.TrimOut = trimOut;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetClipPropertyInput" /> class.
        /// </summary>
        public SetClipPropertyInput()
        {
        }
    }
}