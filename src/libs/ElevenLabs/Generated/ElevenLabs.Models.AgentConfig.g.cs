
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
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::ElevenLabs.ServerAgent? Server { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfig" /> class.
        /// </summary>
        /// <param name="server"></param>
        /// <param name="prompt"></param>
        /// <param name="firstMessage"></param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AgentConfig(
            global::ElevenLabs.ServerAgent? server,
            global::ElevenLabs.PromptAgent? prompt,
            string? firstMessage,
            string? language)
        {
            this.Server = server;
            this.Prompt = prompt;
            this.FirstMessage = firstMessage;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfig" /> class.
        /// </summary>
        public AgentConfig()
        {
        }
    }
}