
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentToolResponseStreamedEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_tool_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentToolResponseClientEventData AgentToolResponse { get; set; }

        /// <summary>
        /// Default Value: agent_tool_response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolResponseStreamedEvent" /> class.
        /// </summary>
        /// <param name="agentToolResponse"></param>
        /// <param name="type">
        /// Default Value: agent_tool_response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentToolResponseStreamedEvent(
            global::ElevenLabs.AgentToolResponseClientEventData agentToolResponse,
            string? type)
        {
            this.AgentToolResponse = agentToolResponse ?? throw new global::System.ArgumentNullException(nameof(agentToolResponse));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolResponseStreamedEvent" /> class.
        /// </summary>
        public AgentToolResponseStreamedEvent()
        {
        }

    }
}