
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"accent":"american","code":"en-american","language":"en","name":"American"}
    /// </summary>
    public sealed partial class VoiceAccentResponseModel
    {
        /// <summary>
        /// The accent value used for filtering shared voices via the `accent` query parameter on `GET /v1/shared-voices`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Accent { get; set; }

        /// <summary>
        /// The language code this accent belongs to, e.g. `en`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// The full accent code, e.g. `en-american`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The human-readable accent name, e.g. `American`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceAccentResponseModel" /> class.
        /// </summary>
        /// <param name="accent">
        /// The accent value used for filtering shared voices via the `accent` query parameter on `GET /v1/shared-voices`.
        /// </param>
        /// <param name="language">
        /// The language code this accent belongs to, e.g. `en`.
        /// </param>
        /// <param name="code">
        /// The full accent code, e.g. `en-american`.
        /// </param>
        /// <param name="name">
        /// The human-readable accent name, e.g. `American`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceAccentResponseModel(
            string accent,
            string language,
            string code,
            string name)
        {
            this.Accent = accent ?? throw new global::System.ArgumentNullException(nameof(accent));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceAccentResponseModel" /> class.
        /// </summary>
        public VoiceAccentResponseModel()
        {
        }

    }
}