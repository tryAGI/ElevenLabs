
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPToolConfigOverrideInput
    {
        /// <summary>
        /// The name of the MCP tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

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
        /// If set, overrides the server's tool_call_sound setting for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound")]
        public global::ElevenLabs.ToolCallSoundType? ToolCallSound { get; set; }

        /// <summary>
        /// If set, overrides the server's tool_call_sound_behavior setting for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound_behavior")]
        public global::ElevenLabs.ToolCallSoundBehavior? ToolCallSoundBehavior { get; set; }

        /// <summary>
        /// If set, overrides the server's execution_mode setting for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        public global::ElevenLabs.ToolExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// Dynamic variable assignments for this MCP tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? Assignments { get; set; }

        /// <summary>
        /// Mapping of json path to input override configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_overrides")]
        public object? InputOverrides { get; set; }

        /// <summary>
        /// Mock responses with optional parameter conditions. Evaluated top-to-bottom; first match wins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_mocks")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>? ResponseMocks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOverrideInput" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The name of the MCP tool
        /// </param>
        /// <param name="preToolSpeech">
        /// If set, overrides the server's pre_tool_speech setting for this tool.
        /// </param>
        /// <param name="disableInterruptions">
        /// If set, overrides the server's disable_interruptions setting for this tool
        /// </param>
        /// <param name="toolCallSound">
        /// If set, overrides the server's tool_call_sound setting for this tool
        /// </param>
        /// <param name="toolCallSoundBehavior">
        /// If set, overrides the server's tool_call_sound_behavior setting for this tool
        /// </param>
        /// <param name="executionMode">
        /// If set, overrides the server's execution_mode setting for this tool
        /// </param>
        /// <param name="assignments">
        /// Dynamic variable assignments for this MCP tool
        /// </param>
        /// <param name="inputOverrides">
        /// Mapping of json path to input override configuration
        /// </param>
        /// <param name="responseMocks">
        /// Mock responses with optional parameter conditions. Evaluated top-to-bottom; first match wins.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolConfigOverrideInput(
            string toolName,
            global::ElevenLabs.PreToolSpeechMode? preToolSpeech,
            bool? disableInterruptions,
            global::ElevenLabs.ToolCallSoundType? toolCallSound,
            global::ElevenLabs.ToolCallSoundBehavior? toolCallSoundBehavior,
            global::ElevenLabs.ToolExecutionMode? executionMode,
            global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? assignments,
            object? inputOverrides,
            global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>? responseMocks)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.PreToolSpeech = preToolSpeech;
            this.DisableInterruptions = disableInterruptions;
            this.ToolCallSound = toolCallSound;
            this.ToolCallSoundBehavior = toolCallSoundBehavior;
            this.ExecutionMode = executionMode;
            this.Assignments = assignments;
            this.InputOverrides = inputOverrides;
            this.ResponseMocks = responseMocks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOverrideInput" /> class.
        /// </summary>
        public MCPToolConfigOverrideInput()
        {
        }
    }
}