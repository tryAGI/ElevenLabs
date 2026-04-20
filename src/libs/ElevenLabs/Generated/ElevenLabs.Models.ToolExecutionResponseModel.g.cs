
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolExecutionResponseModel
    {
        /// <summary>
        /// The ID of the tool that was executed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        /// The request/call ID associated with this tool execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolRequestId { get; set; }

        /// <summary>
        /// The ID of the conversation where the tool was executed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// The ID of the agent that ran the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The branch ID if the agent has branches
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// Unix timestamp when the tool was executed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        /// How long the tool execution took
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LatencySecs { get; set; }

        /// <summary>
        /// Whether the tool execution failed<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// LLM-extracted parameters sent to the tool (JSON string)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_payload")]
        public string? RequestPayload { get; set; }

        /// <summary>
        /// Response returned by the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_payload")]
        public string? ResponsePayload { get; set; }

        /// <summary>
        /// Error message if the tool execution failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Error category (internal, customer_config, customer_auth, external_server, external_client, client_timeout, unknown)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        public string? ErrorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_details")]
        public global::ElevenLabs.ToolCallDetailsVariant1? ToolCallDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolExecutionResponseModel" /> class.
        /// </summary>
        /// <param name="toolId">
        /// The ID of the tool that was executed
        /// </param>
        /// <param name="toolRequestId">
        /// The request/call ID associated with this tool execution
        /// </param>
        /// <param name="conversationId">
        /// The ID of the conversation where the tool was executed
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent that ran the tool
        /// </param>
        /// <param name="timestamp">
        /// Unix timestamp when the tool was executed
        /// </param>
        /// <param name="latencySecs">
        /// How long the tool execution took
        /// </param>
        /// <param name="id"></param>
        /// <param name="branchId">
        /// The branch ID if the agent has branches
        /// </param>
        /// <param name="isError">
        /// Whether the tool execution failed<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestPayload">
        /// LLM-extracted parameters sent to the tool (JSON string)
        /// </param>
        /// <param name="responsePayload">
        /// Response returned by the tool
        /// </param>
        /// <param name="errorMessage">
        /// Error message if the tool execution failed
        /// </param>
        /// <param name="errorType">
        /// Error category (internal, customer_config, customer_auth, external_server, external_client, client_timeout, unknown)
        /// </param>
        /// <param name="toolCallDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolExecutionResponseModel(
            string toolId,
            string toolRequestId,
            string conversationId,
            string agentId,
            double timestamp,
            double latencySecs,
            string id,
            string? branchId,
            bool? isError,
            string? requestPayload,
            string? responsePayload,
            string? errorMessage,
            string? errorType,
            global::ElevenLabs.ToolCallDetailsVariant1? toolCallDetails)
        {
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.ToolRequestId = toolRequestId ?? throw new global::System.ArgumentNullException(nameof(toolRequestId));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.BranchId = branchId;
            this.Timestamp = timestamp;
            this.LatencySecs = latencySecs;
            this.IsError = isError;
            this.RequestPayload = requestPayload;
            this.ResponsePayload = responsePayload;
            this.ErrorMessage = errorMessage;
            this.ErrorType = errorType;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ToolCallDetails = toolCallDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolExecutionResponseModel" /> class.
        /// </summary>
        public ToolExecutionResponseModel()
        {
        }
    }
}