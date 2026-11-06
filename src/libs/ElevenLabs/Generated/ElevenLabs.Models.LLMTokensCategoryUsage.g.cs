
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LLMTokensCategoryUsage
    {
        /// <summary>
        /// Number of tokens in this category.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public int? Tokens { get; set; }

        /// <summary>
        /// Price of these tokens in USD.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMTokensCategoryUsage" /> class.
        /// </summary>
        /// <param name="tokens">
        /// Number of tokens in this category.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="price">
        /// Price of these tokens in USD.<br/>
        /// Default Value: 0F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMTokensCategoryUsage(
            int? tokens,
            double? price)
        {
            this.Tokens = tokens;
            this.Price = price;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMTokensCategoryUsage" /> class.
        /// </summary>
        public LLMTokensCategoryUsage()
        {
        }

    }
}