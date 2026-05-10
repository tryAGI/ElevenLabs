
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssetTranscriptionData2
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
        public required global::System.Collections.Generic.IList<string> Words { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_start_times_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> WordStartTimesMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_end_times_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> WordEndTimesMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_speaker_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> WordSpeakerIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetTranscriptionData2" /> class.
        /// </summary>
        /// <param name="languageCode"></param>
        /// <param name="text"></param>
        /// <param name="words"></param>
        /// <param name="wordStartTimesMs"></param>
        /// <param name="wordEndTimesMs"></param>
        /// <param name="wordSpeakerIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetTranscriptionData2(
            string languageCode,
            string text,
            global::System.Collections.Generic.IList<string> words,
            global::System.Collections.Generic.IList<int> wordStartTimesMs,
            global::System.Collections.Generic.IList<int> wordEndTimesMs,
            global::System.Collections.Generic.IList<string> wordSpeakerIds)
        {
            this.LanguageCode = languageCode ?? throw new global::System.ArgumentNullException(nameof(languageCode));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.WordStartTimesMs = wordStartTimesMs ?? throw new global::System.ArgumentNullException(nameof(wordStartTimesMs));
            this.WordEndTimesMs = wordEndTimesMs ?? throw new global::System.ArgumentNullException(nameof(wordEndTimesMs));
            this.WordSpeakerIds = wordSpeakerIds ?? throw new global::System.ArgumentNullException(nameof(wordSpeakerIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetTranscriptionData2" /> class.
        /// </summary>
        public AssetTranscriptionData2()
        {
        }

    }
}