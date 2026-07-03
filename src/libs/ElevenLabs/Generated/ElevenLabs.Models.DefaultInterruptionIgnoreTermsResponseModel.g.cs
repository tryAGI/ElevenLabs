
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DefaultInterruptionIgnoreTermsResponseModel
    {
        /// <summary>
        /// Curated default interruption ignore terms keyed by language code, split into acknowledgements / openers / confirmations categories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_by_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.InterruptionIgnoreTermSetModel> TermsByLanguage { get; set; }

        /// <summary>
        /// Maximum number of interruption ignore terms allowed on an agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_terms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTerms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultInterruptionIgnoreTermsResponseModel" /> class.
        /// </summary>
        /// <param name="termsByLanguage">
        /// Curated default interruption ignore terms keyed by language code, split into acknowledgements / openers / confirmations categories.
        /// </param>
        /// <param name="maxTerms">
        /// Maximum number of interruption ignore terms allowed on an agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DefaultInterruptionIgnoreTermsResponseModel(
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.InterruptionIgnoreTermSetModel> termsByLanguage,
            int maxTerms)
        {
            this.TermsByLanguage = termsByLanguage ?? throw new global::System.ArgumentNullException(nameof(termsByLanguage));
            this.MaxTerms = maxTerms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultInterruptionIgnoreTermsResponseModel" /> class.
        /// </summary>
        public DefaultInterruptionIgnoreTermsResponseModel()
        {
        }

    }
}