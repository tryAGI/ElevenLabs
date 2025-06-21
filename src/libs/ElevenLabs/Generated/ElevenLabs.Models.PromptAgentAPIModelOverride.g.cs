
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAgentAPIModelOverride
    {
        /// <summary>
        /// The prompt for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOverride" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for the agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAgentAPIModelOverride(
            string? prompt)
        {
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOverride" /> class.
        /// </summary>
        public PromptAgentAPIModelOverride()
        {
        }
    }
}