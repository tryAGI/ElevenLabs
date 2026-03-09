
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"alphabet":"ipa","phoneme":"/\u02C8ta\u026A.l\u00E6nd/","string_to_replace":"Thailand","type":"phoneme"}
    /// </summary>
    public sealed partial class PronunciationDictionaryPhonemeRuleRequestModel
    {
        /// <summary>
        /// The string to replace. Must be a non-empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string_to_replace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string StringToReplace { get; set; } = default!;

        /// <summary>
        /// The type of the rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PronunciationDictionaryPhonemeRuleRequestModelTypeJsonConverter))]
        public global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModelType Type { get; set; }

        /// <summary>
        /// The phoneme rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneme")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Phoneme { get; set; } = default!;

        /// <summary>
        /// The alphabet to use with the phoneme rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alphabet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Alphabet { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryPhonemeRuleRequestModel" /> class.
        /// </summary>
        /// <param name="stringToReplace">
        /// The string to replace. Must be a non-empty string.
        /// </param>
        /// <param name="type">
        /// The type of the rule.
        /// </param>
        /// <param name="phoneme">
        /// The phoneme rule.
        /// </param>
        /// <param name="alphabet">
        /// The alphabet to use with the phoneme rule.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PronunciationDictionaryPhonemeRuleRequestModel(
            string stringToReplace,
            string phoneme,
            string alphabet,
            global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModelType type)
        {
            this.StringToReplace = stringToReplace ?? throw new global::System.ArgumentNullException(nameof(stringToReplace));
            this.Phoneme = phoneme ?? throw new global::System.ArgumentNullException(nameof(phoneme));
            this.Alphabet = alphabet ?? throw new global::System.ArgumentNullException(nameof(alphabet));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictionaryPhonemeRuleRequestModel" /> class.
        /// </summary>
        public PronunciationDictionaryPhonemeRuleRequestModel()
        {
        }
    }
}