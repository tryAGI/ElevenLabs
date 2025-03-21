
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationInitiationClientDataRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config_override")]
        public global::ElevenLabs.ConversationConfigClientOverrideOutput? ConversationConfigOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm_extra_body")]
        public object? CustomLlmExtraBody { get; set; }

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
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataRequest" /> class.
        /// </summary>
        /// <param name="conversationConfigOverride"></param>
        /// <param name="customLlmExtraBody"></param>
        /// <param name="dynamicVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationInitiationClientDataRequest(
            global::ElevenLabs.ConversationConfigClientOverrideOutput? conversationConfigOverride,
            object? customLlmExtraBody,
            object? dynamicVariables)
        {
            this.ConversationConfigOverride = conversationConfigOverride;
            this.CustomLlmExtraBody = customLlmExtraBody;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataRequest" /> class.
        /// </summary>
        public ConversationInitiationClientDataRequest()
        {
        }
    }
}