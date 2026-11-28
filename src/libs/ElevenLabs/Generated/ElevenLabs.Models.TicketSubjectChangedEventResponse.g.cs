
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TicketSubjectChangedEventResponse
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Author8JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Author8 Author { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// Default Value: subject_changed
        /// </summary>
        /// <default>"subject_changed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "subject_changed";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Before { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string After { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketSubjectChangedEventResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="visibility"></param>
        /// <param name="author"></param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="type">
        /// Default Value: subject_changed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TicketSubjectChangedEventResponse(
            string id,
            global::ElevenLabs.TicketEventVisibility visibility,
            global::ElevenLabs.Author8 author,
            int createdAtUnixSecs,
            string before,
            string after,
            string type = "subject_changed")
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
        /// Initializes a new instance of the <see cref="TicketSubjectChangedEventResponse" /> class.
        /// </summary>
        public TicketSubjectChangedEventResponse()
        {
        }

    }
}