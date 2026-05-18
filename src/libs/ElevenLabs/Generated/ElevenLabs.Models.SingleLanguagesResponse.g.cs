
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"kind":"single","languages":[{"code":"en","label":"English"},{"code":"es-ES","label":"Spanish (Spain)"},{"code":"fr","label":"French"}]}
    /// </summary>
    public sealed partial class SingleLanguagesResponse
    {
        /// <summary>
        /// Indicates this response contains single languages (not source-to-destination pairs).<br/>
        /// Default Value: single
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// The list of available languages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.LanguageInfo> Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLanguagesResponse" /> class.
        /// </summary>
        /// <param name="languages">
        /// The list of available languages.
        /// </param>
        /// <param name="kind">
        /// Indicates this response contains single languages (not source-to-destination pairs).<br/>
        /// Default Value: single
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SingleLanguagesResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.LanguageInfo> languages,
            string? kind)
        {
            this.Kind = kind;
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLanguagesResponse" /> class.
        /// </summary>
        public SingleLanguagesResponse()
        {
        }

    }
}