
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientToolCallRequiredAction
    {
        /// <summary>
        /// Default Value: client_tool_call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolCallRequiredAction" /> class.
        /// </summary>
        /// <param name="toolCallId"></param>
        /// <param name="toolName"></param>
        /// <param name="parameters"></param>
        /// <param name="type">
        /// Default Value: client_tool_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolCallRequiredAction(
            string toolCallId,
            string toolName,
            object parameters,
            string? type)
        {
            this.Type = type;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolCallRequiredAction" /> class.
        /// </summary>
        public ClientToolCallRequiredAction()
        {
        }

    }
}