
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenerConfig
    {
        /// <summary>
        /// Model used to speak a fast opener while the main model generates its full reply. Must be a hosted model (not a bring-your-own LLM type).<br/>
        /// Default Value: gemini-2.5-flash
        /// </summary>
        /// <default>global::ElevenLabs.Llm.Gemini25Flash</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.LlmJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Llm Llm { get; set; } = global::ElevenLabs.Llm.Gemini25Flash;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenerConfig" /> class.
        /// </summary>
        /// <param name="llm">
        /// Model used to speak a fast opener while the main model generates its full reply. Must be a hosted model (not a bring-your-own LLM type).<br/>
        /// Default Value: gemini-2.5-flash
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenerConfig(
            global::ElevenLabs.Llm llm)
        {
            this.Llm = llm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenerConfig" /> class.
        /// </summary>
        public OpenerConfig()
        {
        }

    }
}