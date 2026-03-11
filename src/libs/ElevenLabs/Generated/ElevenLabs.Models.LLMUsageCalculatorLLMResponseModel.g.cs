
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMUsageCalculatorLLMResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.LlmJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.Llm Llm { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_per_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double PricePerMinute { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageCalculatorLLMResponseModel" /> class.
        /// </summary>
        /// <param name="llm"></param>
        /// <param name="pricePerMinute"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMUsageCalculatorLLMResponseModel(
            global::ElevenLabs.Llm llm,
            double pricePerMinute)
        {
            this.Llm = llm;
            this.PricePerMinute = pricePerMinute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageCalculatorLLMResponseModel" /> class.
        /// </summary>
        public LLMUsageCalculatorLLMResponseModel()
        {
        }
    }
}