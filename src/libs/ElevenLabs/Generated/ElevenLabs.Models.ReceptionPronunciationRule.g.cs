
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How the receptionist should say one word (or phrase) on calls.<br/>
    /// The rule rewrites only what the receptionist *says* — transcripts, messages<br/>
    /// and everything written keep the original spelling.
    /// </summary>
    public sealed partial class ReceptionPronunciationRule
    {
        /// <summary>
        /// The word or phrase to rewrite, as the receptionist would spell it (e.g. "Frey Design").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

        /// <summary>
        /// Spelled-out text the receptionist should say instead, e.g. "fry design".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pronunciation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionPronunciationRule" /> class.
        /// </summary>
        /// <param name="word">
        /// The word or phrase to rewrite, as the receptionist would spell it (e.g. "Frey Design").
        /// </param>
        /// <param name="pronunciation">
        /// Spelled-out text the receptionist should say instead, e.g. "fry design".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionPronunciationRule(
            string word,
            string pronunciation)
        {
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.Pronunciation = pronunciation ?? throw new global::System.ArgumentNullException(nameof(pronunciation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionPronunciationRule" /> class.
        /// </summary>
        public ReceptionPronunciationRule()
        {
        }

    }
}