
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch
    {
        /// <summary>
        /// The name of the pronunciation dictionary, used for identification only.<br/>
        /// Example: My Dictionary
        /// </summary>
        /// <example>My Dictionary</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// The name of the pronunciation dictionary, used for identification only.<br/>
        /// Example: My Dictionary
        /// </summary>
        /// <example>My Dictionary</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch" /> class.
        /// </summary>
        /// <param name="archived">
        /// The name of the pronunciation dictionary, used for identification only.<br/>
        /// Example: My Dictionary
        /// </param>
        /// <param name="name">
        /// The name of the pronunciation dictionary, used for identification only.<br/>
        /// Example: My Dictionary
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch(
            bool? archived,
            string? name)
        {
            this.Archived = archived;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch" /> class.
        /// </summary>
        public BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch()
        {
        }
    }
}