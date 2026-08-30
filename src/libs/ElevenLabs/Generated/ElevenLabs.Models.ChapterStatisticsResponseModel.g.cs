
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"characters_converted":500,"characters_unconverted":1000,"credits_needed_to_convert":1000,"paragraphs_converted":20,"paragraphs_unconverted":10,"voice_statistics":[{"characters_converted":300,"characters_unconverted":600,"project_voice_ref_id":"voice123","voice_id":"voice123"},{"characters_converted":200,"characters_unconverted":400,"project_voice_ref_id":"voice456","voice_id":"voice456"}]}
    /// </summary>
    public sealed partial class ChapterStatisticsResponseModel
    {
        /// <summary>
        /// The number of unconverted characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_unconverted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharactersUnconverted { get; set; }

        /// <summary>
        /// The number of converted characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_converted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharactersConverted { get; set; }

        /// <summary>
        /// The number of converted paragraphs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paragraphs_converted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ParagraphsConverted { get; set; }

        /// <summary>
        /// The number of unconverted paragraphs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paragraphs_unconverted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ParagraphsUnconverted { get; set; }

        /// <summary>
        /// The number of credits needed to convert the remaining paragraphs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_needed_to_convert")]
        public int? CreditsNeededToConvert { get; set; }

        /// <summary>
        /// Per-voice breakdown of character counts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_statistics")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.VoiceStatisticsResponseModel>? VoiceStatistics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterStatisticsResponseModel" /> class.
        /// </summary>
        /// <param name="charactersUnconverted">
        /// The number of unconverted characters.
        /// </param>
        /// <param name="charactersConverted">
        /// The number of converted characters.
        /// </param>
        /// <param name="paragraphsConverted">
        /// The number of converted paragraphs.
        /// </param>
        /// <param name="paragraphsUnconverted">
        /// The number of unconverted paragraphs.
        /// </param>
        /// <param name="creditsNeededToConvert">
        /// The number of credits needed to convert the remaining paragraphs.
        /// </param>
        /// <param name="voiceStatistics">
        /// Per-voice breakdown of character counts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChapterStatisticsResponseModel(
            int charactersUnconverted,
            int charactersConverted,
            int paragraphsConverted,
            int paragraphsUnconverted,
            int? creditsNeededToConvert,
            global::System.Collections.Generic.IList<global::ElevenLabs.VoiceStatisticsResponseModel>? voiceStatistics)
        {
            this.CharactersUnconverted = charactersUnconverted;
            this.CharactersConverted = charactersConverted;
            this.ParagraphsConverted = paragraphsConverted;
            this.ParagraphsUnconverted = paragraphsUnconverted;
            this.CreditsNeededToConvert = creditsNeededToConvert;
            this.VoiceStatistics = voiceStatistics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterStatisticsResponseModel" /> class.
        /// </summary>
        public ChapterStatisticsResponseModel()
        {
        }

    }
}