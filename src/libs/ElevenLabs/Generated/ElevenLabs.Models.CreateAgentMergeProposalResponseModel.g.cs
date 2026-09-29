
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentMergeProposalResponseModel
    {
        /// <summary>
        /// ID of the created merge_proposal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_merge_proposal_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedMergeProposalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentMergeProposalResponseModel" /> class.
        /// </summary>
        /// <param name="createdMergeProposalId">
        /// ID of the created merge_proposal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentMergeProposalResponseModel(
            string createdMergeProposalId)
        {
            this.CreatedMergeProposalId = createdMergeProposalId ?? throw new global::System.ArgumentNullException(nameof(createdMergeProposalId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentMergeProposalResponseModel" /> class.
        /// </summary>
        public CreateAgentMergeProposalResponseModel()
        {
        }

    }
}