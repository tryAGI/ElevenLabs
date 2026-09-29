
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyCommentOnAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdCommentsPost
    {
        /// <summary>
        /// The comment text. Markdown is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCommentOnAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdCommentsPost" /> class.
        /// </summary>
        /// <param name="body">
        /// The comment text. Markdown is supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCommentOnAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdCommentsPost(
            string body)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCommentOnAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdCommentsPost" /> class.
        /// </summary>
        public BodyCommentOnAMergeProposalV1ConvaiAgentsAgentIdMergeProposalsMergeProposalIdCommentsPost()
        {
        }

    }
}