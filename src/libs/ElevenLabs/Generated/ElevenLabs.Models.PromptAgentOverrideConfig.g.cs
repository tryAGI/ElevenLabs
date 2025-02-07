
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAgentOverrideConfig
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public bool? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentOverrideConfig" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAgentOverrideConfig(
            bool? prompt)
        {
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentOverrideConfig" /> class.
        /// </summary>
        public PromptAgentOverrideConfig()
        {
        }
    }
}