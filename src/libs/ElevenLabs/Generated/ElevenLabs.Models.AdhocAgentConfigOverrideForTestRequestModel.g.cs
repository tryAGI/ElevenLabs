
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdhocAgentConfigOverrideForTestRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConversationalConfigAPIModelInput ConversationConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentPlatformSettingsRequestModel PlatformSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocAgentConfigOverrideForTestRequestModel" /> class.
        /// </summary>
        /// <param name="conversationConfig"></param>
        /// <param name="platformSettings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdhocAgentConfigOverrideForTestRequestModel(
            global::ElevenLabs.ConversationalConfigAPIModelInput conversationConfig,
            global::ElevenLabs.AgentPlatformSettingsRequestModel platformSettings)
        {
            this.ConversationConfig = conversationConfig ?? throw new global::System.ArgumentNullException(nameof(conversationConfig));
            this.PlatformSettings = platformSettings ?? throw new global::System.ArgumentNullException(nameof(platformSettings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocAgentConfigOverrideForTestRequestModel" /> class.
        /// </summary>
        public AdhocAgentConfigOverrideForTestRequestModel()
        {
        }
    }
}