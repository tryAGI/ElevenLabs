
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfigOverride
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::ElevenLabs.PromptAgentOverride? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigOverride" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="firstMessage"></param>
        /// <param name="language"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigOverride(
            global::ElevenLabs.PromptAgentOverride? prompt,
            string? firstMessage,
            string? language)
        {
            this.Prompt = prompt;
            this.FirstMessage = firstMessage;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigOverride" /> class.
        /// </summary>
        public AgentConfigOverride()
        {
        }
    }
}