
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioWithTimestampsResponseModel
    {
        /// <summary>
        /// Base64 encoded audio data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioBase64 { get; set; }

        /// <summary>
        /// Timestamp information for each character in the original text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        public global::ElevenLabs.CharacterAlignmentResponseModel? Alignment { get; set; }

        /// <summary>
        /// Timestamp information for each character in the normalized text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized_alignment")]
        public global::ElevenLabs.CharacterAlignmentResponseModel? NormalizedAlignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioWithTimestampsResponseModel" /> class.
        /// </summary>
        /// <param name="audioBase64">
        /// Base64 encoded audio data
        /// </param>
        /// <param name="alignment">
        /// Timestamp information for each character in the original text
        /// </param>
        /// <param name="normalizedAlignment">
        /// Timestamp information for each character in the normalized text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioWithTimestampsResponseModel(
            string audioBase64,
            global::ElevenLabs.CharacterAlignmentResponseModel? alignment,
            global::ElevenLabs.CharacterAlignmentResponseModel? normalizedAlignment)
        {
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.Alignment = alignment;
            this.NormalizedAlignment = normalizedAlignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioWithTimestampsResponseModel" /> class.
        /// </summary>
        public AudioWithTimestampsResponseModel()
        {
        }
    }
}