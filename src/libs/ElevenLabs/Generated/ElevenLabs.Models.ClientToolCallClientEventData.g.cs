
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientToolCallClientEventData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Parameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EventId { get; set; }

        /// <summary>
        /// Whether the server expects a ClientToolResult response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expects_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExpectsResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolCallClientEventData" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="toolCallId"></param>
        /// <param name="parameters"></param>
        /// <param name="eventId"></param>
        /// <param name="expectsResponse">
        /// Whether the server expects a ClientToolResult response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolCallClientEventData(
            string toolName,
            string toolCallId,
            object parameters,
            int eventId,
            bool expectsResponse)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.EventId = eventId;
            this.ExpectsResponse = expectsResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolCallClientEventData" /> class.
        /// </summary>
        public ClientToolCallClientEventData()
        {
        }

    }
}