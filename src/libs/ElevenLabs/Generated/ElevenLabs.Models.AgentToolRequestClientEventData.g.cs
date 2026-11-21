
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentToolRequestClientEventData
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
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expects_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExpectsResponse { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_interruptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DisableInterruptions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResponseTimeoutSecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolRequestClientEventData" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="toolCallId"></param>
        /// <param name="toolType"></param>
        /// <param name="eventId"></param>
        /// <param name="expectsResponse"></param>
        /// <param name="disableInterruptions"></param>
        /// <param name="responseTimeoutSecs"></param>
        /// <param name="executionMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentToolRequestClientEventData(
            string toolName,
            string toolCallId,
            string toolType,
            int eventId,
            bool expectsResponse,
            bool disableInterruptions,
            int responseTimeoutSecs,
            string executionMode)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolType = toolType ?? throw new global::System.ArgumentNullException(nameof(toolType));
            this.EventId = eventId;
            this.ExpectsResponse = expectsResponse;
            this.DisableInterruptions = disableInterruptions;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.ExecutionMode = executionMode ?? throw new global::System.ArgumentNullException(nameof(executionMode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolRequestClientEventData" /> class.
        /// </summary>
        public AgentToolRequestClientEventData()
        {
        }

    }
}