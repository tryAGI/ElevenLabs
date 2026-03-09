
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"snapshots":[{"created_at_unix":1714204800,"name":"My Project Snapshot","project_id":"aw1NgEzBg83R7vgmiJt6","project_snapshot_id":"aw1NgEzBg83R7vgmiJt6"}]}
    /// </summary>
    public sealed partial class ProjectSnapshotsResponseModel
    {
        /// <summary>
        /// List of project snapshots.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ProjectSnapshotResponseModel> Snapshots { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotsResponseModel" /> class.
        /// </summary>
        /// <param name="snapshots">
        /// List of project snapshots.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSnapshotsResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.ProjectSnapshotResponseModel> snapshots)
        {
            this.Snapshots = snapshots ?? throw new global::System.ArgumentNullException(nameof(snapshots));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotsResponseModel" /> class.
        /// </summary>
        public ProjectSnapshotsResponseModel()
        {
        }
    }
}