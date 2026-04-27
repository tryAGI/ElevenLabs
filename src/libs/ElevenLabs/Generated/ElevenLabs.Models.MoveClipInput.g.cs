
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MoveClipInput
    {
        /// <summary>
        /// ID of the composition node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Source track index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_track_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FromTrackIndex { get; set; }

        /// <summary>
        /// Source clip index within the track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_clip_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FromClipIndex { get; set; }

        /// <summary>
        /// Destination track index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_track_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ToTrackIndex { get; set; }

        /// <summary>
        /// Destination clip position. None appends to the end.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_clip_index")]
        public int? ToClipIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveClipInput" /> class.
        /// </summary>
        /// <param name="nodeId">
        /// ID of the composition node.
        /// </param>
        /// <param name="fromTrackIndex">
        /// Source track index.
        /// </param>
        /// <param name="fromClipIndex">
        /// Source clip index within the track.
        /// </param>
        /// <param name="toTrackIndex">
        /// Destination track index.
        /// </param>
        /// <param name="toClipIndex">
        /// Destination clip position. None appends to the end.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MoveClipInput(
            string nodeId,
            int fromTrackIndex,
            int fromClipIndex,
            int toTrackIndex,
            int? toClipIndex)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.FromTrackIndex = fromTrackIndex;
            this.FromClipIndex = fromClipIndex;
            this.ToTrackIndex = toTrackIndex;
            this.ToClipIndex = toClipIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveClipInput" /> class.
        /// </summary>
        public MoveClipInput()
        {
        }
    }
}