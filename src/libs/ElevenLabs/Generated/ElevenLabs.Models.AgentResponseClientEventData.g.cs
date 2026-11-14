
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentResponseClientEventData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentResponse { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_response_to_ids")]
        public global::System.Collections.Generic.IList<string>? InResponseToIds { get; set; }

        /// <summary>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AgentResponseTypeJsonConverter))]
        public global::ElevenLabs.AgentResponseType? ResponseType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentResponseAttachment>? Attachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseClientEventData" /> class.
        /// </summary>
        /// <param name="agentResponse"></param>
        /// <param name="eventId"></param>
        /// <param name="responseId"></param>
        /// <param name="inResponseToIds"></param>
        /// <param name="responseType">
        /// Default Value: text
        /// </param>
        /// <param name="attachments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentResponseClientEventData(
            string agentResponse,
            int eventId,
            string responseId,
            global::System.Collections.Generic.IList<string>? inResponseToIds,
            global::ElevenLabs.AgentResponseType? responseType,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentResponseAttachment>? attachments)
        {
            this.AgentResponse = agentResponse ?? throw new global::System.ArgumentNullException(nameof(agentResponse));
            this.EventId = eventId;
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.InResponseToIds = inResponseToIds;
            this.ResponseType = responseType;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseClientEventData" /> class.
        /// </summary>
        public AgentResponseClientEventData()
        {
        }

    }
}