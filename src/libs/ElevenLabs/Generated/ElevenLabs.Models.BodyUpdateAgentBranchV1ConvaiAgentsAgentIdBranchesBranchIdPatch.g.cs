
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch
    {
        /// <summary>
        /// New name for the branch. Must be unique within the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New description for the branch. Pass an empty string to clear it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the branch should be archived
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_archived")]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// The protection level for the branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protection_status")]
        public global::ElevenLabs.BranchProtectionStatus? ProtectionStatus { get; set; }

        /// <summary>
        /// When true, rebase this branch automatically after each new version of the branch it is kept in sync with (`sync_branch_id`, main by default). Cannot be enabled on the main branch, or while this branch is more protected than a non-main branch it is kept in sync with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_rebase")]
        public bool? AutoRebase { get; set; }

        /// <summary>
        /// ID of the branch to keep this branch in sync with: its new versions are pulled in automatically while `auto_rebase` is on. Pass the main branch's ID to sync with main again. Must be the main branch or the active branch this branch was created from (`parent_branch_id`). At most 10 branches can be kept in sync with one another in a row. Cannot be set on the main branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_branch_id")]
        public string? SyncBranchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the branch. Must be unique within the agent.
        /// </param>
        /// <param name="description">
        /// New description for the branch. Pass an empty string to clear it.
        /// </param>
        /// <param name="isArchived">
        /// Whether the branch should be archived
        /// </param>
        /// <param name="protectionStatus">
        /// The protection level for the branch
        /// </param>
        /// <param name="autoRebase">
        /// When true, rebase this branch automatically after each new version of the branch it is kept in sync with (`sync_branch_id`, main by default). Cannot be enabled on the main branch, or while this branch is more protected than a non-main branch it is kept in sync with.
        /// </param>
        /// <param name="syncBranchId">
        /// ID of the branch to keep this branch in sync with: its new versions are pulled in automatically while `auto_rebase` is on. Pass the main branch's ID to sync with main again. Must be the main branch or the active branch this branch was created from (`parent_branch_id`). At most 10 branches can be kept in sync with one another in a row. Cannot be set on the main branch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch(
            string? name,
            string? description,
            bool? isArchived,
            global::ElevenLabs.BranchProtectionStatus? protectionStatus,
            bool? autoRebase,
            string? syncBranchId)
        {
            this.Name = name;
            this.Description = description;
            this.IsArchived = isArchived;
            this.ProtectionStatus = protectionStatus;
            this.AutoRebase = autoRebase;
            this.SyncBranchId = syncBranchId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch" /> class.
        /// </summary>
        public BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch()
        {
        }

    }
}