
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A pronunciation dictionary to apply during speech synthesis.
    /// </summary>
    public sealed partial class PronunciationDictionaryVersionLocator
    {
        /// <summary>
        /// The ID of a pronunciation dictionary created via `POST /v1/pronunciation-dictionaries/add-from-file` or `POST /v1/pronunciation-dictionaries/add-from-rules`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PronunciationDictionaryId { get; set; }

        /// <summary>
        /// The version of the dictionary to use. Omit to use the latest version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryVersionLocator" /> class.
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The ID of a pronunciation dictionary created via `POST /v1/pronunciation-dictionaries/add-from-file` or `POST /v1/pronunciation-dictionaries/add-from-rules`.
        /// </param>
        /// <param name="versionId">
        /// The version of the dictionary to use. Omit to use the latest version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryVersionLocator(
            string pronunciationDictionaryId,
            string? versionId)
        {
            this.PronunciationDictionaryId = pronunciationDictionaryId ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryId));
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryVersionLocator" /> class.
        /// </summary>
        public PronunciationDictionaryVersionLocator()
        {
        }

    }
}