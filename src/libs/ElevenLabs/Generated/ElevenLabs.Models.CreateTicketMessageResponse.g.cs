
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTicketMessageResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ticket_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TicketId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TicketMessageEventResponse Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTicketMessageResponse" /> class.
        /// </summary>
        /// <param name="ticketId"></param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTicketMessageResponse(
            string ticketId,
            global::ElevenLabs.TicketMessageEventResponse @event)
        {
            this.TicketId = ticketId ?? throw new global::System.ArgumentNullException(nameof(ticketId));
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTicketMessageResponse" /> class.
        /// </summary>
        public CreateTicketMessageResponse()
        {
        }

    }
}