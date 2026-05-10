
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Unified request model for updating MCP Server configuration.
    /// </summary>
    public sealed partial class MCPServerConfigUpdateRequestModel
    {
        /// <summary>
        /// The approval mode to set for the MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_policy")]
        public global::ElevenLabs.MCPApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// DEPRECATED: use `pre_tool_speech` instead. If set, overrides the server's force_pre_tool_speech setting for this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_pre_tool_speech")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ForcePreToolSpeech { get; set; }

        /// <summary>
        /// If set, overrides the server's pre_tool_speech setting for this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pre_tool_speech")]
        public global::ElevenLabs.PreToolSpeechMode? PreToolSpeech { get; set; }

        /// <summary>
        /// If set, overrides the server's disable_interruptions setting for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_interruptions")]
        public bool? DisableInterruptions { get; set; }

        /// <summary>
        /// Predefined tool call sound type to play during tool execution for all tools from this MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound")]
        public global::ElevenLabs.ToolCallSoundType? ToolCallSound { get; set; }

        /// <summary>
        /// Determines when the tool call sound should play for all tools from this MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound_behavior")]
        public global::ElevenLabs.ToolCallSoundBehavior? ToolCallSoundBehavior { get; set; }

        /// <summary>
        /// If set, overrides the server's execution_mode setting for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        public global::ElevenLabs.ToolExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// The maximum time in seconds to wait for each MCP tool call to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// The headers to include in requests to the MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// Whether to disable HTTP compression for this MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_compression")]
        public bool? DisableCompression { get; set; }

        /// <summary>
        /// Optional secret token for authentication with this MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_token")]
        public global::ElevenLabs.ConvAISecretLocator? SecretToken { get; set; }

        /// <summary>
        /// Optional auth connection to use for authentication with this MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_connection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>))]
        public global::ElevenLabs.AnyOf<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>? AuthConnection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerConfigUpdateRequestModel" /> class.
        /// </summary>
        /// <param name="approvalPolicy">
        /// The approval mode to set for the MCP server
        /// </param>
        /// <param name="preToolSpeech">
        /// If set, overrides the server's pre_tool_speech setting for this tool.
        /// </param>
        /// <param name="disableInterruptions">
        /// If set, overrides the server's disable_interruptions setting for this tool
        /// </param>
        /// <param name="toolCallSound">
        /// Predefined tool call sound type to play during tool execution for all tools from this MCP server
        /// </param>
        /// <param name="toolCallSoundBehavior">
        /// Determines when the tool call sound should play for all tools from this MCP server
        /// </param>
        /// <param name="executionMode">
        /// If set, overrides the server's execution_mode setting for this tool
        /// </param>
        /// <param name="responseTimeoutSecs">
        /// The maximum time in seconds to wait for each MCP tool call to complete.
        /// </param>
        /// <param name="requestHeaders">
        /// The headers to include in requests to the MCP server
        /// </param>
        /// <param name="disableCompression">
        /// Whether to disable HTTP compression for this MCP server
        /// </param>
        /// <param name="secretToken">
        /// Optional secret token for authentication with this MCP server
        /// </param>
        /// <param name="authConnection">
        /// Optional auth connection to use for authentication with this MCP server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerConfigUpdateRequestModel(
            global::ElevenLabs.MCPApprovalPolicy? approvalPolicy,
            global::ElevenLabs.PreToolSpeechMode? preToolSpeech,
            bool? disableInterruptions,
            global::ElevenLabs.ToolCallSoundType? toolCallSound,
            global::ElevenLabs.ToolCallSoundBehavior? toolCallSoundBehavior,
            global::ElevenLabs.ToolExecutionMode? executionMode,
            int? responseTimeoutSecs,
            object? requestHeaders,
            bool? disableCompression,
            global::ElevenLabs.ConvAISecretLocator? secretToken,
            global::ElevenLabs.AnyOf<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>? authConnection)
        {
            this.ApprovalPolicy = approvalPolicy;
            this.PreToolSpeech = preToolSpeech;
            this.DisableInterruptions = disableInterruptions;
            this.ToolCallSound = toolCallSound;
            this.ToolCallSoundBehavior = toolCallSoundBehavior;
            this.ExecutionMode = executionMode;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.RequestHeaders = requestHeaders;
            this.DisableCompression = disableCompression;
            this.SecretToken = secretToken;
            this.AuthConnection = authConnection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerConfigUpdateRequestModel" /> class.
        /// </summary>
        public MCPServerConfigUpdateRequestModel()
        {
        }

    }
}