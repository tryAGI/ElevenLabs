
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TicketSubscribersChangedEventResponse
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Author12JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Author12 Author { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// Default Value: subscribers_changed
        /// </summary>
        /// <default>"subscribers_changed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "subscribers_changed";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TicketSubscriberResponse> Before { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TicketSubscriberResponse> After { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketSubscribersChangedEventResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="visibility"></param>
        /// <param name="author"></param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="type">
        /// Default Value: subscribers_changed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TicketSubscribersChangedEventResponse(
            string id,
            global::ElevenLabs.TicketEventVisibility visibility,
            global::ElevenLabs.Author12 author,
            int createdAtUnixSecs,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSubscriberResponse> before,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSubscriberResponse> after,
            string type = "subscribers_changed")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Visibility = visibility;
            this.Author = author;
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.Type = type;
            this.Before = before ?? throw new global::System.ArgumentNullException(nameof(before));
            this.After = after ?? throw new global::System.ArgumentNullException(nameof(after));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketSubscribersChangedEventResponse" /> class.
        /// </summary>
        public TicketSubscribersChangedEventResponse()
        {
        }

    }
}