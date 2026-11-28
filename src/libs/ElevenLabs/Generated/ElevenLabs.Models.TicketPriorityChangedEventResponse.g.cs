
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TicketPriorityChangedEventResponse
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Author11JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Author11 Author { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// Default Value: priority_changed
        /// </summary>
        /// <default>"priority_changed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "priority_changed";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before")]
        public global::ElevenLabs.TicketPriority? Before { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        public global::ElevenLabs.TicketPriority? After { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketPriorityChangedEventResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="visibility"></param>
        /// <param name="author"></param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="type">
        /// Default Value: priority_changed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TicketPriorityChangedEventResponse(
            string id,
            global::ElevenLabs.TicketEventVisibility visibility,
            global::ElevenLabs.Author11 author,
            int createdAtUnixSecs,
            global::ElevenLabs.TicketPriority? before,
            global::ElevenLabs.TicketPriority? after,
            string type = "priority_changed")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Visibility = visibility;
            this.Author = author;
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.Type = type;
            this.Before = before;
            this.After = after;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketPriorityChangedEventResponse" /> class.
        /// </summary>
        public TicketPriorityChangedEventResponse()
        {
        }

    }
}