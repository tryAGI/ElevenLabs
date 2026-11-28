
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// `ClientToolCallClientEvent` as a stream event, because its custom `__init__` can't parse its own JSON.
    /// </summary>
    public sealed partial class ClientToolCallEvent
    {
        /// <summary>
        /// Default Value: client_tool_call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_tool_call")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ClientToolCallClientEventData ClientToolCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolCallEvent" /> class.
        /// </summary>
        /// <param name="clientToolCall"></param>
        /// <param name="type">
        /// Default Value: client_tool_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolCallEvent(
            global::ElevenLabs.ClientToolCallClientEventData clientToolCall,
            string? type)
        {
            this.Type = type;
            this.ClientToolCall = clientToolCall ?? throw new global::System.ArgumentNullException(nameof(clientToolCall));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolCallEvent" /> class.
        /// </summary>
        public ClientToolCallEvent()
        {
        }

    }
}