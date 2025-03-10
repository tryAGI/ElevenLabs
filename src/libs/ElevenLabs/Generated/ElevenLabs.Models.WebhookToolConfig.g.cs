
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A webhook tool is a tool that calls an external webhook from our server
    /// </summary>
    public sealed partial class WebhookToolConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WebhookToolConfigTypeJsonConverter))]
        public global::ElevenLabs.WebhookToolConfigType Type { get; set; }

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
        /// Configuration for a webhook that will be called by an LLM tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.WebhookToolApiSchemaConfig ApiSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::ElevenLabs.DynamicVariablesConfig? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="apiSchema">
        /// Configuration for a webhook that will be called by an LLM tool.
        /// </param>
        /// <param name="dynamicVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookToolConfig(
            string name,
            string description,
            global::ElevenLabs.WebhookToolApiSchemaConfig apiSchema,
            global::ElevenLabs.WebhookToolConfigType type,
            global::ElevenLabs.DynamicVariablesConfig? dynamicVariables)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ApiSchema = apiSchema ?? throw new global::System.ArgumentNullException(nameof(apiSchema));
            this.Type = type;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolConfig" /> class.
        /// </summary>
        public WebhookToolConfig()
        {
        }
    }
}