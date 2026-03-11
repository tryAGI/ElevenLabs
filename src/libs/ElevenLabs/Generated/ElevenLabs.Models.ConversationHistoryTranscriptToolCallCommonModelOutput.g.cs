
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptToolCallCommonModelOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::ElevenLabs.ToolType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params_as_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ParamsAsJson { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_has_been_called")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool ToolHasBeenCalled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_details")]
        public global::ElevenLabs.ToolDetailsVariant12? ToolDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallCommonModelOutput" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="requestId"></param>
        /// <param name="toolName"></param>
        /// <param name="paramsAsJson"></param>
        /// <param name="toolHasBeenCalled"></param>
        /// <param name="toolDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryTranscriptToolCallCommonModelOutput(
            string requestId,
            string toolName,
            string paramsAsJson,
            bool toolHasBeenCalled,
            global::ElevenLabs.ToolType? type,
            global::ElevenLabs.ToolDetailsVariant12? toolDetails)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ParamsAsJson = paramsAsJson ?? throw new global::System.ArgumentNullException(nameof(paramsAsJson));
            this.ToolHasBeenCalled = toolHasBeenCalled;
            this.Type = type;
            this.ToolDetails = toolDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallCommonModelOutput" /> class.
        /// </summary>
        public ConversationHistoryTranscriptToolCallCommonModelOutput()
        {
        }
    }
}