
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoTranscription
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguageCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.VideoTranscriptionWord> Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTranscription" /> class.
        /// </summary>
        /// <param name="languageCode"></param>
        /// <param name="text"></param>
        /// <param name="words"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTranscription(
            string languageCode,
            string text,
            global::System.Collections.Generic.IList<global::ElevenLabs.VideoTranscriptionWord> words)
        {
            this.LanguageCode = languageCode ?? throw new global::System.ArgumentNullException(nameof(languageCode));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTranscription" /> class.
        /// </summary>
        public VideoTranscription()
        {
        }
    }
}