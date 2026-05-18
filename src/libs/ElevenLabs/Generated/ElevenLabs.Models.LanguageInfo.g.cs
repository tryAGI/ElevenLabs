
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"code":"es-ES","label":"Spanish (Spain)"}
    /// </summary>
    public sealed partial class LanguageInfo
    {
        /// <summary>
        /// The language code (e.g. 'en', 'fr', 'es-ES').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The human-readable language name (e.g. 'English', 'French', 'Spanish (Spain)').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageInfo" /> class.
        /// </summary>
        /// <param name="code">
        /// The language code (e.g. 'en', 'fr', 'es-ES').
        /// </param>
        /// <param name="label">
        /// The human-readable language name (e.g. 'English', 'French', 'Spanish (Spain)').
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguageInfo(
            string code,
            string label)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageInfo" /> class.
        /// </summary>
        public LanguageInfo()
        {
        }

    }
}