
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TicketCreatedEventResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TicketEventVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TicketEventVisibility Visibility { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Author3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Author3 Author { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// Default Value: ticket_created
        /// </summary>
        /// <default>"ticket_created"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "ticket_created";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public global::ElevenLabs.TicketPriority? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketCreatedEventResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="visibility"></param>
        /// <param name="author"></param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="priority"></param>
        /// <param name="type">
        /// Default Value: ticket_created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TicketCreatedEventResponse(
            string id,
            global::ElevenLabs.TicketEventVisibility visibility,
            global::ElevenLabs.Author3 author,
            int createdAtUnixSecs,
            global::ElevenLabs.TicketPriority? priority,
            string type = "ticket_created")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Visibility = visibility;
            this.Author = author;
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.Type = type;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketCreatedEventResponse" /> class.
        /// </summary>
        public TicketCreatedEventResponse()
        {
        }

    }
}