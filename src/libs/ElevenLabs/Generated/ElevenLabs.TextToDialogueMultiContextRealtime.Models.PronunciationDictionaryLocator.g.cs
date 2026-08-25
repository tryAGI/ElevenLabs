
#nullable enable

namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    /// <summary>
    /// Identifies a specific pronunciation dictionary to use
    /// </summary>
    public sealed partial class PronunciationDictionaryLocator
    {
        /// <summary>
        /// The unique identifier of the pronunciation dictionary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PronunciationDictionaryId { get; set; }

        /// <summary>
        /// The version identifier of the pronunciation dictionary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryLocator" /> class.
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The unique identifier of the pronunciation dictionary
        /// </param>
        /// <param name="versionId">
        /// The version identifier of the pronunciation dictionary
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryLocator(
            string pronunciationDictionaryId,
            string versionId)
        {
            this.PronunciationDictionaryId = pronunciationDictionaryId ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryId));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryLocator" /> class.
        /// </summary>
        public PronunciationDictionaryLocator()
        {
        }

    }
}