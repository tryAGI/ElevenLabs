
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentGuardrailOutput
    {
        /// <summary>
        /// Default Value: streaming
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeJsonConverter))]
        public global::ElevenLabs.GuardrailExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::ElevenLabs.ContentConfig? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TriggerAction2JsonConverter))]
        public global::ElevenLabs.TriggerAction2? TriggerAction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGuardrailOutput" /> class.
        /// </summary>
        /// <param name="executionMode">
        /// Default Value: streaming
        /// </param>
        /// <param name="config"></param>
        /// <param name="triggerAction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentGuardrailOutput(
            global::ElevenLabs.GuardrailExecutionMode? executionMode,
            global::ElevenLabs.ContentConfig? config,
            global::ElevenLabs.TriggerAction2? triggerAction)
        {
            this.ExecutionMode = executionMode;
            this.Config = config;
            this.TriggerAction = triggerAction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGuardrailOutput" /> class.
        /// </summary>
        public ContentGuardrailOutput()
        {
        }

    }
}