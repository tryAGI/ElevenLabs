
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeConfigSnapshotParents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_snapshot_id")]
        public string? PreviousSnapshotId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConfigSnapshotParents" /> class.
        /// </summary>
        /// <param name="previousSnapshotId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConfigSnapshotParents(
            string? previousSnapshotId)
        {
            this.PreviousSnapshotId = previousSnapshotId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConfigSnapshotParents" /> class.
        /// </summary>
        public RealtimeConfigSnapshotParents()
        {
        }

    }
}