
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentResponseClientEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_response_event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentResponseClientEventData AgentResponseEvent { get; set; }

        /// <summary>
        /// Default Value: agent_response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseClientEvent" /> class.
        /// </summary>
        /// <param name="agentResponseEvent"></param>
        /// <param name="type">
        /// Default Value: agent_response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentResponseClientEvent(
            global::ElevenLabs.AgentResponseClientEventData agentResponseEvent,
            string? type)
        {
            this.AgentResponseEvent = agentResponseEvent ?? throw new global::System.ArgumentNullException(nameof(agentResponseEvent));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseClientEvent" /> class.
        /// </summary>
        public AgentResponseClientEvent()
        {
        }

    }
}