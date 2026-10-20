
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenAIAudioInputTranscription
    {
        /// <summary>
        /// Language code of the conversation (e.g. en, es, pt-br), used for transcription, speech and the model's reply language. Defaults to en.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIAudioInputTranscription" /> class.
        /// </summary>
        /// <param name="language">
        /// Language code of the conversation (e.g. en, es, pt-br), used for transcription, speech and the model's reply language. Defaults to en.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIAudioInputTranscription(
            string? language)
        {
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIAudioInputTranscription" /> class.
        /// </summary>
        public OpenAIAudioInputTranscription()
        {
        }

    }
}