
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIAudioInputFormat
    {
        /// <summary>
        /// Default Value: audio/pcm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AudioFormatJsonConverter))]
        public global::ElevenLabs.AudioFormat? Type { get; set; }

        /// <summary>
        /// Default Value: 24000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public int? Rate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIAudioInputFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: audio/pcm
        /// </param>
        /// <param name="rate">
        /// Default Value: 24000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIAudioInputFormat(
            global::ElevenLabs.AudioFormat? type,
            int? rate)
        {
            this.Type = type;
            this.Rate = rate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIAudioInputFormat" /> class.
        /// </summary>
        public OpenAIAudioInputFormat()
        {
        }

    }
}