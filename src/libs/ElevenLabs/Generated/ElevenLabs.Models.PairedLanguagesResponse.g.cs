
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"kind":"pair","language_pairs":[{"destination_languages":[{"code":"es","label":"Spanish"},{"code":"es-ES","label":"Spanish (Spain)"},{"code":"fr","label":"French"}],"source_language":{"code":"en","label":"English"}},{"destination_languages":[{"code":"en","label":"English"}],"source_language":{"code":"es-ES","label":"Spanish (Spain)"}}]}
    /// </summary>
    public sealed partial class PairedLanguagesResponse
    {
        /// <summary>
        /// Indicates this response contains source-to-destination language pairs.<br/>
        /// Default Value: pair
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// The list of available source-to-destination language mappings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_pairs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.LanguagePairInfo> LanguagePairs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PairedLanguagesResponse" /> class.
        /// </summary>
        /// <param name="languagePairs">
        /// The list of available source-to-destination language mappings.
        /// </param>
        /// <param name="kind">
        /// Indicates this response contains source-to-destination language pairs.<br/>
        /// Default Value: pair
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PairedLanguagesResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.LanguagePairInfo> languagePairs,
            string? kind)
        {
            this.Kind = kind;
            this.LanguagePairs = languagePairs ?? throw new global::System.ArgumentNullException(nameof(languagePairs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PairedLanguagesResponse" /> class.
        /// </summary>
        public PairedLanguagesResponse()
        {
        }

    }
}