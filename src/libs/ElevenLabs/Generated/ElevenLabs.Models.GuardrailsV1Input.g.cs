
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailsV1Input
    {
        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("focus")]
        public global::ElevenLabs.FocusGuardrail? Focus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_injection")]
        public global::ElevenLabs.PromptInjectionGuardrail? PromptInjection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::ElevenLabs.ContentGuardrailInput? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        public global::ElevenLabs.ModerationGuardrailInput? Moderation { get; set; }

        /// <summary>
        /// Container for custom guardrails, matching ModerationGuardrail pattern
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        public global::ElevenLabs.CustomGuardrailInput? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsV1Input" /> class.
        /// </summary>
        /// <param name="version">
        /// Default Value: 1
        /// </param>
        /// <param name="focus"></param>
        /// <param name="promptInjection"></param>
        /// <param name="content"></param>
        /// <param name="moderation"></param>
        /// <param name="custom">
        /// Container for custom guardrails, matching ModerationGuardrail pattern
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailsV1Input(
            string? version,
            global::ElevenLabs.FocusGuardrail? focus,
            global::ElevenLabs.PromptInjectionGuardrail? promptInjection,
            global::ElevenLabs.ContentGuardrailInput? content,
            global::ElevenLabs.ModerationGuardrailInput? moderation,
            global::ElevenLabs.CustomGuardrailInput? custom)
        {
            this.Version = version;
            this.Focus = focus;
            this.PromptInjection = promptInjection;
            this.Content = content;
            this.Moderation = moderation;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsV1Input" /> class.
        /// </summary>
        public GuardrailsV1Input()
        {
        }

    }
}