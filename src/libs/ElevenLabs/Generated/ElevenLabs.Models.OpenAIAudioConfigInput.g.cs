
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenAIAudioConfigInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::ElevenLabs.OpenAIAudioInputConfigInput? Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::ElevenLabs.OpenAIAudioOutputConfigInput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIAudioConfigInput" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIAudioConfigInput(
            global::ElevenLabs.OpenAIAudioInputConfigInput? input,
            global::ElevenLabs.OpenAIAudioOutputConfigInput? output)
        {
            this.Input = input;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIAudioConfigInput" /> class.
        /// </summary>
        public OpenAIAudioConfigInput()
        {
        }

    }
}