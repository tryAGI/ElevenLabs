
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenAIAudioInputConfigInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public global::ElevenLabs.OpenAIAudioInputFormat? Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::ElevenLabs.OpenAIAudioInputTranscription? Transcription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::ElevenLabs.OpenAITurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// ``BURSTY`` clients stream ahead of wall time, so decisions use the audio clock.<br/>
        /// Default Value: realtime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pacing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AudioInputPacingJsonConverter))]
        public global::ElevenLabs.AudioInputPacing? Pacing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIAudioInputConfigInput" /> class.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="transcription"></param>
        /// <param name="turnDetection"></param>
        /// <param name="pacing">
        /// ``BURSTY`` clients stream ahead of wall time, so decisions use the audio clock.<br/>
        /// Default Value: realtime
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIAudioInputConfigInput(
            global::ElevenLabs.OpenAIAudioInputFormat? format,
            global::ElevenLabs.OpenAIAudioInputTranscription? transcription,
            global::ElevenLabs.OpenAITurnDetection? turnDetection,
            global::ElevenLabs.AudioInputPacing? pacing)
        {
            this.Format = format;
            this.Transcription = transcription;
            this.TurnDetection = turnDetection;
            this.Pacing = pacing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIAudioInputConfigInput" /> class.
        /// </summary>
        public OpenAIAudioInputConfigInput()
        {
        }

    }
}