
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentToolRequestStreamedEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_tool_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentToolRequestClientEventData AgentToolRequest { get; set; }

        /// <summary>
        /// Default Value: agent_tool_request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolRequestStreamedEvent" /> class.
        /// </summary>
        /// <param name="agentToolRequest"></param>
        /// <param name="type">
        /// Default Value: agent_tool_request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentToolRequestStreamedEvent(
            global::ElevenLabs.AgentToolRequestClientEventData agentToolRequest,
            string? type)
        {
            this.AgentToolRequest = agentToolRequest ?? throw new global::System.ArgumentNullException(nameof(agentToolRequest));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolRequestStreamedEvent" /> class.
        /// </summary>
        public AgentToolRequestStreamedEvent()
        {
        }

    }
}