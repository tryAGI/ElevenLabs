
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponse
    {
        /// <summary>
        /// Base64 encoded audio data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base64")]
        public string? AudioBase64 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        public global::ElevenLabs.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponseAlignment? Alignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized_alignment")]
        public global::ElevenLabs.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponseNormalizedAlignment? NormalizedAlignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponse" /> class.
        /// </summary>
        /// <param name="audioBase64">
        /// Base64 encoded audio data
        /// </param>
        /// <param name="alignment"></param>
        /// <param name="normalizedAlignment"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponse(
            string? audioBase64,
            global::ElevenLabs.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponseAlignment? alignment,
            global::ElevenLabs.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponseNormalizedAlignment? normalizedAlignment)
        {
            this.AudioBase64 = audioBase64;
            this.Alignment = alignment;
            this.NormalizedAlignment = normalizedAlignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponse" /> class.
        /// </summary>
        public TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponse()
        {
        }
    }
}