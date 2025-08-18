
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyComposeMusicV1MusicPost
    {
        /// <summary>
        /// A simple text prompt to generate a song from. Cannot be used in conjunction with `composition_plan`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_prompt")]
        public global::ElevenLabs.MusicPrompt? MusicPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_plan")]
        public global::ElevenLabs.MusicPrompt? CompositionPlan { get; set; }

        /// <summary>
        /// The length of the song to generate in milliseconds. Used only in conjunction with `prompt`. Must be between 10000ms and 300000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_length_ms")]
        public int? MusicLengthMs { get; set; }

        /// <summary>
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BodyComposeMusicV1MusicPostModelIdJsonConverter))]
        public global::ElevenLabs.BodyComposeMusicV1MusicPostModelId? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyComposeMusicV1MusicPost" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A simple text prompt to generate a song from. Cannot be used in conjunction with `composition_plan`.
        /// </param>
        /// <param name="musicPrompt"></param>
        /// <param name="compositionPlan"></param>
        /// <param name="musicLengthMs">
        /// The length of the song to generate in milliseconds. Used only in conjunction with `prompt`. Must be between 10000ms and 300000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyComposeMusicV1MusicPost(
            string? prompt,
            global::ElevenLabs.MusicPrompt? musicPrompt,
            global::ElevenLabs.MusicPrompt? compositionPlan,
            int? musicLengthMs,
            global::ElevenLabs.BodyComposeMusicV1MusicPostModelId? modelId)
        {
            this.Prompt = prompt;
            this.MusicPrompt = musicPrompt;
            this.CompositionPlan = compositionPlan;
            this.MusicLengthMs = musicLengthMs;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyComposeMusicV1MusicPost" /> class.
        /// </summary>
        public BodyComposeMusicV1MusicPost()
        {
        }
    }
}