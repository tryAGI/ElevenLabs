
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentResponseModel
    {
        /// <summary>
        /// The ID of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The name of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConversationalConfigAPIModelOutput ConversationConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentMetadataResponseModel Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_settings")]
        public global::ElevenLabs.AgentPlatformSettingsResponseModel? PlatformSettings { get; set; }

        /// <summary>
        /// The phone numbers of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem>? PhoneNumbers { get; set; }

        /// <summary>
        /// The workflow of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public object? Workflow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        public global::ElevenLabs.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// Agent tags used to categorize the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseModel" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent
        /// </param>
        /// <param name="name">
        /// The name of the agent
        /// </param>
        /// <param name="conversationConfig"></param>
        /// <param name="metadata"></param>
        /// <param name="platformSettings"></param>
        /// <param name="phoneNumbers">
        /// The phone numbers of the agent
        /// </param>
        /// <param name="workflow">
        /// The workflow of the agent
        /// </param>
        /// <param name="accessInfo"></param>
        /// <param name="tags">
        /// Agent tags used to categorize the agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentResponseModel(
            string agentId,
            string name,
            global::ElevenLabs.ConversationalConfigAPIModelOutput conversationConfig,
            global::ElevenLabs.AgentMetadataResponseModel metadata,
            global::ElevenLabs.AgentPlatformSettingsResponseModel? platformSettings,
            global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem>? phoneNumbers,
            object? workflow,
            global::ElevenLabs.ResourceAccessInfo? accessInfo,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ConversationConfig = conversationConfig ?? throw new global::System.ArgumentNullException(nameof(conversationConfig));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.PlatformSettings = platformSettings;
            this.PhoneNumbers = phoneNumbers;
            this.Workflow = workflow;
            this.AccessInfo = accessInfo;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseModel" /> class.
        /// </summary>
        public GetAgentResponseModel()
        {
        }
    }
}