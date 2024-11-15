
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAgent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Default Value: gemini-1.5-flash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.LLMJsonConverter))]
        public global::ElevenLabs.LLM? Llm { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.PromptAgentToolConfig>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseLocator>? KnowledgeBase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgent" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="llm">
        /// Default Value: gemini-1.5-flash
        /// </param>
        /// <param name="temperature">
        /// Default Value: 0
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: -1
        /// </param>
        /// <param name="tools"></param>
        /// <param name="knowledgeBase"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PromptAgent(
            string prompt,
            global::ElevenLabs.LLM? llm,
            double? temperature,
            int? maxTokens,
            global::System.Collections.Generic.IList<global::ElevenLabs.PromptAgentToolConfig>? tools,
            global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseLocator>? knowledgeBase)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Llm = llm;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.Tools = tools;
            this.KnowledgeBase = knowledgeBase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgent" /> class.
        /// </summary>
        public PromptAgent()
        {
        }
    }
}