
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyGenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPost
    {
        /// <summary>
        /// Description to use for the created voice.<br/>
        /// Example: A sassy little squeaky mouse
        /// </summary>
        /// <example>A sassy little squeaky mouse</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceDescription { get; set; }

        /// <summary>
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </summary>
        /// <example>Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPost" /> class.
        /// </summary>
        /// <param name="voiceDescription">
        /// Description to use for the created voice.<br/>
        /// Example: A sassy little squeaky mouse
        /// </param>
        /// <param name="text">
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BodyGenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPost(
            string voiceDescription,
            string text)
        {
            this.VoiceDescription = voiceDescription ?? throw new global::System.ArgumentNullException(nameof(voiceDescription));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPost" /> class.
        /// </summary>
        public BodyGenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPost()
        {
        }
    }
}