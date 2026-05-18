
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"destination_languages":[{"code":"es-ES","label":"Spanish (Spain)"},{"code":"fr","label":"French"}],"source_language":{"code":"en","label":"English"}}
    /// </summary>
    public sealed partial class LanguagePairInfo
    {
        /// <summary>
        /// The source language.<br/>
        /// Example: {"code":"es-ES","label":"Spanish (Spain)"}
        /// </summary>
        /// <example>{"code":"es-ES","label":"Spanish (Spain)"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.LanguageInfo SourceLanguage { get; set; }

        /// <summary>
        /// The available destination languages for this source language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.LanguageInfo> DestinationLanguages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePairInfo" /> class.
        /// </summary>
        /// <param name="sourceLanguage">
        /// The source language.<br/>
        /// Example: {"code":"es-ES","label":"Spanish (Spain)"}
        /// </param>
        /// <param name="destinationLanguages">
        /// The available destination languages for this source language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguagePairInfo(
            global::ElevenLabs.LanguageInfo sourceLanguage,
            global::System.Collections.Generic.IList<global::ElevenLabs.LanguageInfo> destinationLanguages)
        {
            this.SourceLanguage = sourceLanguage ?? throw new global::System.ArgumentNullException(nameof(sourceLanguage));
            this.DestinationLanguages = destinationLanguages ?? throw new global::System.ArgumentNullException(nameof(destinationLanguages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePairInfo" /> class.
        /// </summary>
        public LanguagePairInfo()
        {
        }

    }
}