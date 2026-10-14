
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MergeAgentConversationTicketsRequestModel
    {
        /// <summary>
        /// Open tickets of the same agent to fold into this one. They are kept with status 'merged', pointing at this ticket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_ticket_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SourceTicketIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeAgentConversationTicketsRequestModel" /> class.
        /// </summary>
        /// <param name="sourceTicketIds">
        /// Open tickets of the same agent to fold into this one. They are kept with status 'merged', pointing at this ticket.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MergeAgentConversationTicketsRequestModel(
            global::System.Collections.Generic.IList<string> sourceTicketIds)
        {
            this.SourceTicketIds = sourceTicketIds ?? throw new global::System.ArgumentNullException(nameof(sourceTicketIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeAgentConversationTicketsRequestModel" /> class.
        /// </summary>
        public MergeAgentConversationTicketsRequestModel()
        {
        }

    }
}