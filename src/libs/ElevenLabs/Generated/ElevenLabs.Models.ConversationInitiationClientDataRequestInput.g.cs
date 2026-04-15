
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationInitiationClientDataRequestInput
    {
        /// <summary>
        /// Example: {"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"knowledge_base":[],"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","tool_ids":[]}},"tts":{"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"soft_timeout_config":{"message":"Hhmmmm...yeah."}}}
        /// </summary>
        /// <example>{"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"knowledge_base":[],"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","tool_ids":[]}},"tts":{"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"soft_timeout_config":{"message":"Hhmmmm...yeah."}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config_override")]
        public global::ElevenLabs.ConversationConfigClientOverrideInput? ConversationConfigOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm_extra_body")]
        public object? CustomLlmExtraBody { get; set; }

        /// <summary>
        /// ID of the end user participating in this conversation (for agent owner's user identification)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Information about the source of conversation initiation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_info")]
        public global::ElevenLabs.ConversationInitiationSourceInfo? SourceInfo { get; set; }

        /// <summary>
        /// ID of the agent branch to use for this conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// Environment to use for resolving environment variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// If set, start the workflow at this node id instead of the default entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starting_workflow_node_id")]
        public string? StartingWorkflowNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataRequestInput" /> class.
        /// </summary>
        /// <param name="conversationConfigOverride">
        /// Example: {"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"knowledge_base":[],"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","tool_ids":[]}},"tts":{"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"soft_timeout_config":{"message":"Hhmmmm...yeah."}}}
        /// </param>
        /// <param name="customLlmExtraBody"></param>
        /// <param name="userId">
        /// ID of the end user participating in this conversation (for agent owner's user identification)
        /// </param>
        /// <param name="sourceInfo">
        /// Information about the source of conversation initiation
        /// </param>
        /// <param name="branchId">
        /// ID of the agent branch to use for this conversation
        /// </param>
        /// <param name="environment">
        /// Environment to use for resolving environment variables
        /// </param>
        /// <param name="startingWorkflowNodeId">
        /// If set, start the workflow at this node id instead of the default entry
        /// </param>
        /// <param name="dynamicVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationInitiationClientDataRequestInput(
            global::ElevenLabs.ConversationConfigClientOverrideInput? conversationConfigOverride,
            object? customLlmExtraBody,
            string? userId,
            global::ElevenLabs.ConversationInitiationSourceInfo? sourceInfo,
            string? branchId,
            string? environment,
            string? startingWorkflowNodeId,
            object? dynamicVariables)
        {
            this.ConversationConfigOverride = conversationConfigOverride;
            this.CustomLlmExtraBody = customLlmExtraBody;
            this.UserId = userId;
            this.SourceInfo = sourceInfo;
            this.BranchId = branchId;
            this.Environment = environment;
            this.StartingWorkflowNodeId = startingWorkflowNodeId;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataRequestInput" /> class.
        /// </summary>
        public ConversationInitiationClientDataRequestInput()
        {
        }
    }
}