
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A `client_tool_result` whose `type` is required, so that it can share `input` with other items.
    /// </summary>
    public sealed partial class ClientToolResultItem
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"client_tool_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "client_tool_result";

        /// <summary>
        /// ID of the tool call this result corresponds to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsError { get; set; }

        /// <summary>
        /// Optional category for the failure reason. When set, `is_error` is treated as true. `user_rejected` is special-cased to mark the tool as not having been called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        public global::ElevenLabs.ClientToolResultItemErrorType? ErrorType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolResultItem" /> class.
        /// </summary>
        /// <param name="toolCallId">
        /// ID of the tool call this result corresponds to.
        /// </param>
        /// <param name="result"></param>
        /// <param name="isError"></param>
        /// <param name="errorType">
        /// Optional category for the failure reason. When set, `is_error` is treated as true. `user_rejected` is special-cased to mark the tool as not having been called.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolResultItem(
            string toolCallId,
            string result,
            bool isError,
            global::ElevenLabs.ClientToolResultItemErrorType? errorType,
            string type = "client_tool_result")
        {
            this.Type = type;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.IsError = isError;
            this.ErrorType = errorType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolResultItem" /> class.
        /// </summary>
        public ClientToolResultItem()
        {
        }

    }
}