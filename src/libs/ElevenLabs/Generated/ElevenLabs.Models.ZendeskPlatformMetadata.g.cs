
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ZendeskPlatformMetadata
    {
        /// <summary>
        /// Default Value: zendesk_integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_initiation_source")]
        public string? ConversationInitiationSource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ticket_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TicketId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ZendeskPlatformMetadata" /> class.
        /// </summary>
        /// <param name="ticketId"></param>
        /// <param name="conversationInitiationSource">
        /// Default Value: zendesk_integration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ZendeskPlatformMetadata(
            string ticketId,
            string? conversationInitiationSource)
        {
            this.ConversationInitiationSource = conversationInitiationSource;
            this.TicketId = ticketId ?? throw new global::System.ArgumentNullException(nameof(ticketId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZendeskPlatformMetadata" /> class.
        /// </summary>
        public ZendeskPlatformMetadata()
        {
        }

    }
}