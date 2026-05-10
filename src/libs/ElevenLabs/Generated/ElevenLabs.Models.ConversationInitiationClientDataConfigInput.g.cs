
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"custom_llm_extra_body":true,"enable_conversation_initiation_client_data_from_webhook":true,"enable_starting_workflow_node_id_from_client":true}
    /// </summary>
    public sealed partial class ConversationInitiationClientDataConfigInput
    {
        /// <summary>
        /// Overrides for the conversation configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config_override")]
        public global::ElevenLabs.ConversationConfigClientOverrideConfigInput? ConversationConfigOverride { get; set; }

        /// <summary>
        /// Whether to include custom LLM extra body<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm_extra_body")]
        public bool? CustomLlmExtraBody { get; set; }

        /// <summary>
        /// Whether to enable conversation initiation client data from webhooks<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_conversation_initiation_client_data_from_webhook")]
        public bool? EnableConversationInitiationClientDataFromWebhook { get; set; }

        /// <summary>
        /// Whether clients may pass starting_workflow_node_id in initiation client data; if false, sending it fails conversation start.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_starting_workflow_node_id_from_client")]
        public bool? EnableStartingWorkflowNodeIdFromClient { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataConfigInput" /> class.
        /// </summary>
        /// <param name="conversationConfigOverride">
        /// Overrides for the conversation configuration
        /// </param>
        /// <param name="customLlmExtraBody">
        /// Whether to include custom LLM extra body<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableConversationInitiationClientDataFromWebhook">
        /// Whether to enable conversation initiation client data from webhooks<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableStartingWorkflowNodeIdFromClient">
        /// Whether clients may pass starting_workflow_node_id in initiation client data; if false, sending it fails conversation start.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationInitiationClientDataConfigInput(
            global::ElevenLabs.ConversationConfigClientOverrideConfigInput? conversationConfigOverride,
            bool? customLlmExtraBody,
            bool? enableConversationInitiationClientDataFromWebhook,
            bool? enableStartingWorkflowNodeIdFromClient)
        {
            this.ConversationConfigOverride = conversationConfigOverride;
            this.CustomLlmExtraBody = customLlmExtraBody;
            this.EnableConversationInitiationClientDataFromWebhook = enableConversationInitiationClientDataFromWebhook;
            this.EnableStartingWorkflowNodeIdFromClient = enableStartingWorkflowNodeIdFromClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataConfigInput" /> class.
        /// </summary>
        public ConversationInitiationClientDataConfigInput()
        {
        }

    }
}