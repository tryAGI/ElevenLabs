
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiIntegrationWebhookToolConfigInput
    {
        /// <summary>
        /// Default Value: api_integration_webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of when the tool should be used and what it does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The maximum time in seconds to wait for the tool call to complete. Must be between 5 and 120 seconds (inclusive).<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// If true, the user will not be able to interrupt the agent while this tool is running.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_interruptions")]
        public bool? DisableInterruptions { get; set; }

        /// <summary>
        /// DEPRECATED: use `pre_tool_speech` instead. If true, the agent will speak before the tool call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_pre_tool_speech")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ForcePreToolSpeech { get; set; }

        /// <summary>
        /// Controls whether the agent speaks before this tool is called. 'auto' (default) decides based on recent tool latency, 'force' always asks the agent to speak, 'off' fully opts out regardless of latency.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pre_tool_speech")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PreToolSpeechModeJsonConverter))]
        public global::ElevenLabs.PreToolSpeechMode? PreToolSpeech { get; set; }

        /// <summary>
        /// Configuration for extracting values from tool responses and assigning them to dynamic variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? Assignments { get; set; }

        /// <summary>
        /// Predefined tool call sound type to play during tool execution. If not specified, no tool call sound will be played.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound")]
        public global::ElevenLabs.ToolCallSoundType? ToolCallSound { get; set; }

        /// <summary>
        /// Determines when the tool call sound should play. 'auto' only plays when there's pre-tool speech, 'always' plays for every tool call.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ToolCallSoundBehaviorJsonConverter))]
        public global::ElevenLabs.ToolCallSoundBehavior? ToolCallSoundBehavior { get; set; }

        /// <summary>
        /// Controls how tool errors are processed before being shared with the agent. 'auto' determines handling based on tool type (summarized for native integrations, hide for others), 'summarized' sends an LLM-generated summary, 'passthrough' sends the raw error, 'hide' does not share the error with the agent.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_error_handling_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ToolErrorHandlingModeJsonConverter))]
        public global::ElevenLabs.ToolErrorHandlingMode? ToolErrorHandlingMode { get; set; }

        /// <summary>
        /// Configuration for dynamic variables<br/>
        /// Example: {"dynamic_variable_placeholders":{"user_name":"John Doe"}}
        /// </summary>
        /// <example>{"dynamic_variable_placeholders":{"user_name":"John Doe"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::ElevenLabs.DynamicVariablesConfigInput? DynamicVariables { get; set; }

        /// <summary>
        /// Determines when and how the tool executes: 'immediate' executes the tool right away when requested by the LLM, 'post_tool_speech' waits for the agent to finish speaking before executing, 'async' runs the tool in the background without blocking - best for long-running operations.<br/>
        /// Default Value: immediate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ToolExecutionModeJsonConverter))]
        public global::ElevenLabs.ToolExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// The version of the API integration tool<br/>
        /// Default Value: 1.0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_version")]
        public string? ToolVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_integration_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiIntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_integration_connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiIntegrationConnectionId { get; set; }

        /// <summary>
        /// User overrides applied on top of the base api_schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_schema_overrides")]
        public global::ElevenLabs.ApiIntegrationWebhookOverrides? ApiSchemaOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationWebhookToolConfigInput" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description">
        /// Description of when the tool should be used and what it does.
        /// </param>
        /// <param name="apiIntegrationId"></param>
        /// <param name="apiIntegrationConnectionId"></param>
        /// <param name="type">
        /// Default Value: api_integration_webhook
        /// </param>
        /// <param name="responseTimeoutSecs">
        /// The maximum time in seconds to wait for the tool call to complete. Must be between 5 and 120 seconds (inclusive).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="disableInterruptions">
        /// If true, the user will not be able to interrupt the agent while this tool is running.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="preToolSpeech">
        /// Controls whether the agent speaks before this tool is called. 'auto' (default) decides based on recent tool latency, 'force' always asks the agent to speak, 'off' fully opts out regardless of latency.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="assignments">
        /// Configuration for extracting values from tool responses and assigning them to dynamic variables
        /// </param>
        /// <param name="toolCallSound">
        /// Predefined tool call sound type to play during tool execution. If not specified, no tool call sound will be played.
        /// </param>
        /// <param name="toolCallSoundBehavior">
        /// Determines when the tool call sound should play. 'auto' only plays when there's pre-tool speech, 'always' plays for every tool call.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="toolErrorHandlingMode">
        /// Controls how tool errors are processed before being shared with the agent. 'auto' determines handling based on tool type (summarized for native integrations, hide for others), 'summarized' sends an LLM-generated summary, 'passthrough' sends the raw error, 'hide' does not share the error with the agent.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="dynamicVariables">
        /// Configuration for dynamic variables<br/>
        /// Example: {"dynamic_variable_placeholders":{"user_name":"John Doe"}}
        /// </param>
        /// <param name="executionMode">
        /// Determines when and how the tool executes: 'immediate' executes the tool right away when requested by the LLM, 'post_tool_speech' waits for the agent to finish speaking before executing, 'async' runs the tool in the background without blocking - best for long-running operations.<br/>
        /// Default Value: immediate
        /// </param>
        /// <param name="toolVersion">
        /// The version of the API integration tool<br/>
        /// Default Value: 1.0.0
        /// </param>
        /// <param name="apiSchemaOverrides">
        /// User overrides applied on top of the base api_schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiIntegrationWebhookToolConfigInput(
            string name,
            string description,
            string apiIntegrationId,
            string apiIntegrationConnectionId,
            string? type,
            int? responseTimeoutSecs,
            bool? disableInterruptions,
            global::ElevenLabs.PreToolSpeechMode? preToolSpeech,
            global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? assignments,
            global::ElevenLabs.ToolCallSoundType? toolCallSound,
            global::ElevenLabs.ToolCallSoundBehavior? toolCallSoundBehavior,
            global::ElevenLabs.ToolErrorHandlingMode? toolErrorHandlingMode,
            global::ElevenLabs.DynamicVariablesConfigInput? dynamicVariables,
            global::ElevenLabs.ToolExecutionMode? executionMode,
            string? toolVersion,
            global::ElevenLabs.ApiIntegrationWebhookOverrides? apiSchemaOverrides)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.DisableInterruptions = disableInterruptions;
            this.PreToolSpeech = preToolSpeech;
            this.Assignments = assignments;
            this.ToolCallSound = toolCallSound;
            this.ToolCallSoundBehavior = toolCallSoundBehavior;
            this.ToolErrorHandlingMode = toolErrorHandlingMode;
            this.DynamicVariables = dynamicVariables;
            this.ExecutionMode = executionMode;
            this.ToolVersion = toolVersion;
            this.ApiIntegrationId = apiIntegrationId ?? throw new global::System.ArgumentNullException(nameof(apiIntegrationId));
            this.ApiIntegrationConnectionId = apiIntegrationConnectionId ?? throw new global::System.ArgumentNullException(nameof(apiIntegrationConnectionId));
            this.ApiSchemaOverrides = apiSchemaOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationWebhookToolConfigInput" /> class.
        /// </summary>
        public ApiIntegrationWebhookToolConfigInput()
        {
        }
    }
}