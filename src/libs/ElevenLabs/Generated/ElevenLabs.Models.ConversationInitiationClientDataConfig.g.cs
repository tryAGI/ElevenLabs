
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationInitiationClientDataConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config_override")]
        public global::ElevenLabs.ConversationConfigClientOverrideConfig? ConversationConfigOverride { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm_extra_body")]
        public bool? CustomLlmExtraBody { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_conversation_initiation_client_data_from_webhook")]
        public bool? EnableConversationInitiationClientDataFromWebhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataConfig" /> class.
        /// </summary>
        /// <param name="conversationConfigOverride"></param>
        /// <param name="customLlmExtraBody">
        /// Default Value: false
        /// </param>
        /// <param name="enableConversationInitiationClientDataFromWebhook">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationInitiationClientDataConfig(
            global::ElevenLabs.ConversationConfigClientOverrideConfig? conversationConfigOverride,
            bool? customLlmExtraBody,
            bool? enableConversationInitiationClientDataFromWebhook)
        {
            this.ConversationConfigOverride = conversationConfigOverride;
            this.CustomLlmExtraBody = customLlmExtraBody;
            this.EnableConversationInitiationClientDataFromWebhook = enableConversationInitiationClientDataFromWebhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataConfig" /> class.
        /// </summary>
        public ConversationInitiationClientDataConfig()
        {
        }
    }
}