
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIAudioOutputConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public global::ElevenLabs.OpenAIAudioOutputFormat? Format { get; set; }

        /// <summary>
        /// Default Value: brian
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIAudioOutputConfig" /> class.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="voice">
        /// Default Value: brian
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIAudioOutputConfig(
            global::ElevenLabs.OpenAIAudioOutputFormat? format,
            string? voice)
        {
            this.Format = format;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIAudioOutputConfig" /> class.
        /// </summary>
        public OpenAIAudioOutputConfig()
        {
        }

    }
}