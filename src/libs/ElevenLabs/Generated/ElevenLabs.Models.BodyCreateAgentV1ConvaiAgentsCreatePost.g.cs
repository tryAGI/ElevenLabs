
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateAgentV1ConvaiAgentsCreatePost
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
        public global::ElevenLabs.AgentPlatformSettingsRequestModel? PlatformSettings { get; set; }

        /// <summary>
        /// Workflow for the agent. This is used to define the flow of the conversation and how the agent interacts with tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public object? Workflow { get; set; }

        /// <summary>
        /// A name to make the agent easier to find<br/>
        /// Example: My agent
        /// </summary>
        /// <example>My agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Tags to help classify and filter the agent<br/>
        /// Example: [Customer Support, Technical Help, Eleven]
        /// </summary>
        /// <example>[Customer Support, Technical Help, Eleven]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAgentV1ConvaiAgentsCreatePost" /> class.
        /// </summary>
        /// <param name="conversationConfig"></param>
        /// <param name="platformSettings"></param>
        /// <param name="workflow">
        /// Workflow for the agent. This is used to define the flow of the conversation and how the agent interacts with tools.
        /// </param>
        /// <param name="name">
        /// A name to make the agent easier to find<br/>
        /// Example: My agent
        /// </param>
        /// <param name="tags">
        /// Tags to help classify and filter the agent<br/>
        /// Example: [Customer Support, Technical Help, Eleven]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateAgentV1ConvaiAgentsCreatePost(
            global::ElevenLabs.ConversationalConfigAPIModelInput conversationConfig,
            global::ElevenLabs.AgentPlatformSettingsRequestModel? platformSettings,
            object? workflow,
            string? name,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.ConversationConfig = conversationConfig ?? throw new global::System.ArgumentNullException(nameof(conversationConfig));
            this.PlatformSettings = platformSettings;
            this.Workflow = workflow;
            this.Name = name;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAgentV1ConvaiAgentsCreatePost" /> class.
        /// </summary>
        public BodyCreateAgentV1ConvaiAgentsCreatePost()
        {
        }
    }
}