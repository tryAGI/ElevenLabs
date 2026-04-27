
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetTrackPropertyInput
    {
        /// <summary>
        /// ID of the composition node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Zero-based index of the track to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrackIndex { get; set; }

        /// <summary>
        /// Track volume (0.0-10.0).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Whether to mute the track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mute")]
        public bool? Mute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTrackPropertyInput" /> class.
        /// </summary>
        /// <param name="nodeId">
        /// ID of the composition node.
        /// </param>
        /// <param name="trackIndex">
        /// Zero-based index of the track to update.
        /// </param>
        /// <param name="volume">
        /// Track volume (0.0-10.0).
        /// </param>
        /// <param name="mute">
        /// Whether to mute the track.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetTrackPropertyInput(
            string nodeId,
            int trackIndex,
            double? volume,
            bool? mute)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.TrackIndex = trackIndex;
            this.Volume = volume;
            this.Mute = mute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTrackPropertyInput" /> class.
        /// </summary>
        public SetTrackPropertyInput()
        {
        }
    }
}