
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::ElevenLabs.PromptAgent? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentConfig" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="firstMessage"></param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="dynamicVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfig(
            global::ElevenLabs.PromptAgent? prompt,
            string? firstMessage,
            string? language,
            global::ElevenLabs.DynamicVariablesConfig? dynamicVariables)
        {
            this.Prompt = prompt;
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfig" /> class.
        /// </summary>
        public AgentConfig()
        {
        }
    }
}