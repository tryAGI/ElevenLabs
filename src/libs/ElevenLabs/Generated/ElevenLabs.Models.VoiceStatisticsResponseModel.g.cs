
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceStatisticsResponseModel
    {
        /// <summary>
        /// The project voice reference ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_voice_ref_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectVoiceRefId { get; set; }

        /// <summary>
        /// The number of unconverted characters for this voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_unconverted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharactersUnconverted { get; set; }

        /// <summary>
        /// The number of converted characters for this voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_converted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharactersConverted { get; set; }

        /// <summary>
        /// The number of credits needed to convert the remaining audio for this voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_needed_to_convert")]
        public int? CreditsNeededToConvert { get; set; }

        /// <summary>
        /// The voice ID.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStatisticsResponseModel" /> class.
        /// </summary>
        /// <param name="projectVoiceRefId">
        /// The project voice reference ID.
        /// </param>
        /// <param name="charactersUnconverted">
        /// The number of unconverted characters for this voice.
        /// </param>
        /// <param name="charactersConverted">
        /// The number of converted characters for this voice.
        /// </param>
        /// <param name="creditsNeededToConvert">
        /// The number of credits needed to convert the remaining audio for this voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceStatisticsResponseModel(
            string projectVoiceRefId,
            int charactersUnconverted,
            int charactersConverted,
            int? creditsNeededToConvert)
        {
            this.ProjectVoiceRefId = projectVoiceRefId ?? throw new global::System.ArgumentNullException(nameof(projectVoiceRefId));
            this.CharactersUnconverted = charactersUnconverted;
            this.CharactersConverted = charactersConverted;
            this.CreditsNeededToConvert = creditsNeededToConvert;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStatisticsResponseModel" /> class.
        /// </summary>
        public VoiceStatisticsResponseModel()
        {
        }

    }
}