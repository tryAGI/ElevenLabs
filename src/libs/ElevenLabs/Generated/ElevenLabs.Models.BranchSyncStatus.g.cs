
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BranchSyncStatus
    {
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
        /// <param name="lastAttempt">
        /// Latest automatic attempt to pull the synced branch's new versions in, run after each of them. Null when none has run since sync was turned on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchSyncStatus(
            global::ElevenLabs.AutoRebaseAttempt? lastAttempt)
        {
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