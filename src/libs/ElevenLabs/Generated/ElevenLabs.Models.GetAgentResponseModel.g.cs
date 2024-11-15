
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConversationalConfig ConversationConfig { get; set; }

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
        public global::ElevenLabs.AgentPlatformSettings? PlatformSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="name"></param>
        /// <param name="conversationConfig"></param>
        /// <param name="metadata"></param>
        /// <param name="platformSettings"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetAgentResponseModel(
            string agentId,
            string name,
            global::ElevenLabs.ConversationalConfig conversationConfig,
            global::ElevenLabs.AgentMetadataResponseModel metadata,
            global::ElevenLabs.AgentPlatformSettings? platformSettings)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ConversationConfig = conversationConfig ?? throw new global::System.ArgumentNullException(nameof(conversationConfig));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.PlatformSettings = platformSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseModel" /> class.
        /// </summary>
        public GetAgentResponseModel()
        {
        }
    }
}