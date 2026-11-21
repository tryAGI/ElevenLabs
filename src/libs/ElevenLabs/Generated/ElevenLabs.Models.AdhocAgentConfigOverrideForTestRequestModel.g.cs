
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdhocAgentConfigOverrideForTestRequestModel
    {
        /// <summary>
        /// Conversation config fields to change for this run. Fields left out keep the agent's values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config")]
        public global::ElevenLabs.ConversationalConfigAPIModelInput? ConversationConfig { get; set; }

        /// <summary>
        /// Platform settings fields to change for this run. Fields left out keep the agent's values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_settings")]
        public global::ElevenLabs.AgentPlatformSettingsRequestModel? PlatformSettings { get; set; }

        /// <summary>
        /// A workflow to run instead of the agent's. It replaces the agent's workflow whole.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::ElevenLabs.AgentWorkflowRequestModel? Workflow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocAgentConfigOverrideForTestRequestModel" /> class.
        /// </summary>
        /// <param name="conversationConfig">
        /// Conversation config fields to change for this run. Fields left out keep the agent's values.
        /// </param>
        /// <param name="platformSettings">
        /// Platform settings fields to change for this run. Fields left out keep the agent's values.
        /// </param>
        /// <param name="workflow">
        /// A workflow to run instead of the agent's. It replaces the agent's workflow whole.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdhocAgentConfigOverrideForTestRequestModel(
            global::ElevenLabs.ConversationalConfigAPIModelInput? conversationConfig,
            global::ElevenLabs.AgentPlatformSettingsRequestModel? platformSettings,
            global::ElevenLabs.AgentWorkflowRequestModel? workflow)
        {
            this.ConversationConfig = conversationConfig;
            this.PlatformSettings = platformSettings;
            this.Workflow = workflow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocAgentConfigOverrideForTestRequestModel" /> class.
        /// </summary>
        public AdhocAgentConfigOverrideForTestRequestModel()
        {
        }

    }
}