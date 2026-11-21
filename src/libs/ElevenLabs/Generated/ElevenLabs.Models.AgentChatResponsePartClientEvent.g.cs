
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentChatResponsePartClientEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_response_part")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentChatResponsePartClientEventData TextResponsePart { get; set; }

        /// <summary>
        /// Default Value: agent_chat_response_part
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatResponsePartClientEvent" /> class.
        /// </summary>
        /// <param name="textResponsePart"></param>
        /// <param name="type">
        /// Default Value: agent_chat_response_part
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentChatResponsePartClientEvent(
            global::ElevenLabs.AgentChatResponsePartClientEventData textResponsePart,
            string? type)
        {
            this.TextResponsePart = textResponsePart ?? throw new global::System.ArgumentNullException(nameof(textResponsePart));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatResponsePartClientEvent" /> class.
        /// </summary>
        public AgentChatResponsePartClientEvent()
        {
        }

    }
}