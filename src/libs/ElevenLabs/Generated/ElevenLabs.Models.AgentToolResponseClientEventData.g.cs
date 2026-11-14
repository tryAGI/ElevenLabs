
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentToolResponseClientEventData
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
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsError { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_blocked")]
        public bool? IsBlocked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_called")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCalled { get; set; }

        /// <summary>
        /// Tool call status derived from execution flags.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AgentToolResponseStatusJsonConverter))]
        public global::ElevenLabs.AgentToolResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolResponseClientEventData" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="toolCallId"></param>
        /// <param name="toolType"></param>
        /// <param name="isError"></param>
        /// <param name="eventId"></param>
        /// <param name="isCalled"></param>
        /// <param name="isBlocked">
        /// Default Value: false
        /// </param>
        /// <param name="status">
        /// Tool call status derived from execution flags.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentToolResponseClientEventData(
            string toolName,
            string toolCallId,
            string toolType,
            bool isError,
            int eventId,
            bool isCalled,
            bool? isBlocked,
            global::ElevenLabs.AgentToolResponseStatus status = default!)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolType = toolType ?? throw new global::System.ArgumentNullException(nameof(toolType));
            this.IsError = isError;
            this.IsBlocked = isBlocked;
            this.EventId = eventId;
            this.IsCalled = isCalled;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolResponseClientEventData" /> class.
        /// </summary>
        public AgentToolResponseClientEventData()
        {
        }

    }
}