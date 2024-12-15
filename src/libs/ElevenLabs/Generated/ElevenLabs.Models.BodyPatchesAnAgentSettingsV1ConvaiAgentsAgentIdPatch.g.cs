
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch
    {
        /// <summary>
        /// Conversation configuration for an agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config")]
        public object? ConversationConfig { get; set; }

        /// <summary>
        /// Platform settings for the agent are all settings that aren't related to the conversation orchestration and content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_settings")]
        public object? PlatformSettings { get; set; }

        /// <summary>
        /// A list of secrets for the agent. Can be used to add new secrets or update and delete the existing ones
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAINewSecretConfig, global::ElevenLabs.ConvAIStoredSecretConfig>>? Secrets { get; set; }

        /// <summary>
        /// A name to make the agent easier to find
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch" /> class.
        /// </summary>
        /// <param name="conversationConfig">
        /// Conversation configuration for an agent
        /// </param>
        /// <param name="platformSettings">
        /// Platform settings for the agent are all settings that aren't related to the conversation orchestration and content.
        /// </param>
        /// <param name="secrets">
        /// A list of secrets for the agent. Can be used to add new secrets or update and delete the existing ones
        /// </param>
        /// <param name="name">
        /// A name to make the agent easier to find
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch(
            object? conversationConfig,
            object? platformSettings,
            global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAINewSecretConfig, global::ElevenLabs.ConvAIStoredSecretConfig>>? secrets,
            string? name)
        {
            this.ConversationConfig = conversationConfig;
            this.PlatformSettings = platformSettings;
            this.Secrets = secrets;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch" /> class.
        /// </summary>
        public BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch()
        {
        }
    }
}