
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TicketMergeProposalLinkResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_proposal_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MergeProposalId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linked_by_user_id")]
        public string? LinkedByUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linked_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LinkedAtUnixSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketMergeProposalLinkResponseModel" /> class.
        /// </summary>
        /// <param name="mergeProposalId"></param>
        /// <param name="linkedAtUnixSecs"></param>
        /// <param name="linkedByUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TicketMergeProposalLinkResponseModel(
            string mergeProposalId,
            int linkedAtUnixSecs,
            string? linkedByUserId)
        {
            this.MergeProposalId = mergeProposalId ?? throw new global::System.ArgumentNullException(nameof(mergeProposalId));
            this.LinkedByUserId = linkedByUserId;
            this.LinkedAtUnixSecs = linkedAtUnixSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketMergeProposalLinkResponseModel" /> class.
        /// </summary>
        public TicketMergeProposalLinkResponseModel()
        {
        }

    }
}