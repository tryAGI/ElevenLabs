
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A configuration for a tool/function that the agent can use over the course of the conversation.<br/>
    /// Initially we only support webhooks, but it is likely we will want to support more types in the future.<br/>
    /// TODO can we include more of these best practises<br/>
    ///     https://cloud.google.com/vertex-ai/generative-ai/docs/multimodal/function-calling#best-practices
    /// </summary>
    public sealed partial class PromptAgentToolConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PromptAgentToolConfigTypeJsonConverter))]
        public global::ElevenLabs.PromptAgentToolConfigType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeholder_statement")]
        public string? PlaceholderStatement { get; set; }

        /// <summary>
        /// Configuration for a webhook that will be called by an LLM tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ToolWebhookConfig ApiSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentToolConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="placeholderStatement"></param>
        /// <param name="apiSchema">
        /// Configuration for a webhook that will be called by an LLM tool.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PromptAgentToolConfig(
            string name,
            string description,
            global::ElevenLabs.ToolWebhookConfig apiSchema,
            global::ElevenLabs.PromptAgentToolConfigType type,
            string? placeholderStatement)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ApiSchema = apiSchema ?? throw new global::System.ArgumentNullException(nameof(apiSchema));
            this.Type = type;
            this.PlaceholderStatement = placeholderStatement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentToolConfig" /> class.
        /// </summary>
        public PromptAgentToolConfig()
        {
        }
    }
}