
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BranchSyncStatus
    {
        /// <summary>
        /// ID of the branch this branch is kept in sync with: its new versions are pulled in automatically while `auto_rebase` is on. The main branch unless another was chosen. While the chosen branch is archived this still names it, and main is used in its place.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// Latest automatic attempt to pull the synced branch's new versions in, run after each of them. Null when none has run since sync was turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_attempt")]
        public global::ElevenLabs.AutoRebaseAttempt? LastAttempt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSyncStatus" /> class.
        /// </summary>
        /// <param name="branchId">
        /// ID of the branch this branch is kept in sync with: its new versions are pulled in automatically while `auto_rebase` is on. The main branch unless another was chosen. While the chosen branch is archived this still names it, and main is used in its place.
        /// </param>
        /// <param name="lastAttempt">
        /// Latest automatic attempt to pull the synced branch's new versions in, run after each of them. Null when none has run since sync was turned on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchSyncStatus(
            string branchId,
            global::ElevenLabs.AutoRebaseAttempt? lastAttempt)
        {
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.LastAttempt = lastAttempt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSyncStatus" /> class.
        /// </summary>
        public BranchSyncStatus()
        {
        }

    }
}