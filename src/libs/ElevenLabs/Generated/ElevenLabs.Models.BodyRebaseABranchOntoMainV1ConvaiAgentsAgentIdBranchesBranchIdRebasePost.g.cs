
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyRebaseABranchOntoMainV1ConvaiAgentsAgentIdBranchesBranchIdRebasePost
    {
        /// <summary>
        /// Side to keep, or custom text where the conflict accepts it, for each conflict the preview reported. A merge or rebase with conflicts is rejected unless there is one for every conflict, sent with both tip ids. On a merge it can't be combined with `force`, which lets the source win every conflict instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conflict_resolutions")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConflictResolution>? ConflictResolutions { get; set; }

        /// <summary>
        /// Tip version of the branch being rebased (`source_tip_version_id` of the rebase preview) the conflicts were resolved against. The request fails with 409 if it moved since.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_tip_id")]
        public string? BranchTipId { get; set; }

        /// <summary>
        /// Tip version of the branch the changes are pulled from (`source_branch_id`, the main branch by default; `target_tip_version_id` of the rebase preview) the conflicts were resolved against. The request fails with 409 if it moved since.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_tip_id")]
        public string? SourceTipId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRebaseABranchOntoMainV1ConvaiAgentsAgentIdBranchesBranchIdRebasePost" /> class.
        /// </summary>
        /// <param name="conflictResolutions">
        /// Side to keep, or custom text where the conflict accepts it, for each conflict the preview reported. A merge or rebase with conflicts is rejected unless there is one for every conflict, sent with both tip ids. On a merge it can't be combined with `force`, which lets the source win every conflict instead.
        /// </param>
        /// <param name="branchTipId">
        /// Tip version of the branch being rebased (`source_tip_version_id` of the rebase preview) the conflicts were resolved against. The request fails with 409 if it moved since.
        /// </param>
        /// <param name="sourceTipId">
        /// Tip version of the branch the changes are pulled from (`source_branch_id`, the main branch by default; `target_tip_version_id` of the rebase preview) the conflicts were resolved against. The request fails with 409 if it moved since.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyRebaseABranchOntoMainV1ConvaiAgentsAgentIdBranchesBranchIdRebasePost(
            global::System.Collections.Generic.IList<global::ElevenLabs.ConflictResolution>? conflictResolutions,
            string? branchTipId,
            string? sourceTipId)
        {
            this.ConflictResolutions = conflictResolutions;
            this.BranchTipId = branchTipId;
            this.SourceTipId = sourceTipId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRebaseABranchOntoMainV1ConvaiAgentsAgentIdBranchesBranchIdRebasePost" /> class.
        /// </summary>
        public BodyRebaseABranchOntoMainV1ConvaiAgentsAgentIdBranchesBranchIdRebasePost()
        {
        }

    }
}