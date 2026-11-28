
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost
    {
        /// <summary>
        /// Whether to archive the source branch after merging<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive_source_branch")]
        public bool? ArchiveSourceBranch { get; set; }

        /// <summary>
        /// Keep the source branch's value for every conflict instead of sending `conflict_resolutions`<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Side to keep, or custom text where the conflict accepts it, for each conflict the preview reported. A merge or rebase with conflicts is rejected unless there is one for every conflict, sent with both tip ids. On a merge it can't be combined with `force`, which lets the source win every conflict instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conflict_resolutions")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConflictResolution>? ConflictResolutions { get; set; }

        /// <summary>
        /// Source branch tip version the conflicts were resolved against (`source_tip_version_id` of the preview). The request fails with 409 if the branch moved since.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_tip_id")]
        public string? SourceTipId { get; set; }

        /// <summary>
        /// Target branch tip version the conflicts were resolved against (`target_tip_version_id` of the preview). The request fails with 409 if the branch moved since.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_tip_id")]
        public string? TargetTipId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost" /> class.
        /// </summary>
        /// <param name="archiveSourceBranch">
        /// Whether to archive the source branch after merging<br/>
        /// Default Value: true
        /// </param>
        /// <param name="force">
        /// Keep the source branch's value for every conflict instead of sending `conflict_resolutions`<br/>
        /// Default Value: false
        /// </param>
        /// <param name="conflictResolutions">
        /// Side to keep, or custom text where the conflict accepts it, for each conflict the preview reported. A merge or rebase with conflicts is rejected unless there is one for every conflict, sent with both tip ids. On a merge it can't be combined with `force`, which lets the source win every conflict instead.
        /// </param>
        /// <param name="sourceTipId">
        /// Source branch tip version the conflicts were resolved against (`source_tip_version_id` of the preview). The request fails with 409 if the branch moved since.
        /// </param>
        /// <param name="targetTipId">
        /// Target branch tip version the conflicts were resolved against (`target_tip_version_id` of the preview). The request fails with 409 if the branch moved since.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost(
            bool? archiveSourceBranch,
            bool? force,
            global::System.Collections.Generic.IList<global::ElevenLabs.ConflictResolution>? conflictResolutions,
            string? sourceTipId,
            string? targetTipId)
        {
            this.ArchiveSourceBranch = archiveSourceBranch;
            this.Force = force;
            this.ConflictResolutions = conflictResolutions;
            this.SourceTipId = sourceTipId;
            this.TargetTipId = targetTipId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost" /> class.
        /// </summary>
        public BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost()
        {
        }

    }
}