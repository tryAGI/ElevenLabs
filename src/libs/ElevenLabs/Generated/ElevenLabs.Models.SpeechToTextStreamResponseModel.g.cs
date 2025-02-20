
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///             The streaming endpoint returns a sequence of these chunks, each separated by double newlines.<br/>
    ///             Example stream (formatted for readability):<br/>
    ///             {"language_code": "en", "language_probability": 0.0, "text": "This is an example", "words": [...]}\n\n<br/>
    ///             {"language_code": "en", "language_probability": 0.0, "text": "of a streamed transcription", "words": [...]}\n\n<br/>
    ///             {"language_code": "en", "language_probability": 1.0, "text": "with each chunk separated by double newlines.", "words": [...]}<br/>
    ///             
    /// </summary>
    public sealed partial class SpeechToTextStreamResponseModel
    {
        /// <summary>
        /// The detected language code (e.g. 'eng' for English).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguageCode { get; set; }

        /// <summary>
        /// The confidence score of the language detection (0 to 1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_probability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LanguageProbability { get; set; }

        /// <summary>
        /// The raw text of the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// List of words with their timing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextWordResponseModel> Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextStreamResponseModel" /> class.
        /// </summary>
        /// <param name="languageCode">
        /// The detected language code (e.g. 'eng' for English).
        /// </param>
        /// <param name="languageProbability">
        /// The confidence score of the language detection (0 to 1).
        /// </param>
        /// <param name="text">
        /// The raw text of the transcription.
        /// </param>
        /// <param name="words">
        /// List of words with their timing information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextStreamResponseModel(
            string languageCode,
            double languageProbability,
            string text,
            global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextWordResponseModel> words)
        {
            this.LanguageCode = languageCode ?? throw new global::System.ArgumentNullException(nameof(languageCode));
            this.LanguageProbability = languageProbability;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextStreamResponseModel" /> class.
        /// </summary>
        public SpeechToTextStreamResponseModel()
        {
        }
    }
}