
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReorderTracksInput
    {
        /// <summary>
        /// ID of the composition node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// New track order as list of current track indices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> TrackOrder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReorderTracksInput" /> class.
        /// </summary>
        /// <param name="nodeId">
        /// ID of the composition node.
        /// </param>
        /// <param name="trackOrder">
        /// New track order as list of current track indices.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReorderTracksInput(
            string nodeId,
            global::System.Collections.Generic.IList<int> trackOrder)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.TrackOrder = trackOrder ?? throw new global::System.ArgumentNullException(nameof(trackOrder));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReorderTracksInput" /> class.
        /// </summary>
        public ReorderTracksInput()
        {
        }
    }
}