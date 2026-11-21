
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentReasoningResponsePartClientEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_response_part")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentReasoningResponsePartClientEventData ReasoningResponsePart { get; set; }

        /// <summary>
        /// Default Value: agent_reasoning_response_part
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReasoningResponsePartClientEvent" /> class.
        /// </summary>
        /// <param name="reasoningResponsePart"></param>
        /// <param name="type">
        /// Default Value: agent_reasoning_response_part
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentReasoningResponsePartClientEvent(
            global::ElevenLabs.AgentReasoningResponsePartClientEventData reasoningResponsePart,
            string? type)
        {
            this.ReasoningResponsePart = reasoningResponsePart ?? throw new global::System.ArgumentNullException(nameof(reasoningResponsePart));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReasoningResponsePartClientEvent" /> class.
        /// </summary>
        public AgentReasoningResponsePartClientEvent()
        {
        }

    }
}