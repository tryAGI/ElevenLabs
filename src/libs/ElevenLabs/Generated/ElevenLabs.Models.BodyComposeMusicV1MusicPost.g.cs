
#pragma warning disable CS0618 // Type or member is obsolete

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
        /// Optional generation mode hint for prompt-based music generation. Can only be used with `prompt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_mode")]
        public global::ElevenLabs.MusicGenerationMode? GenerationMode { get; set; }

        /// <summary>
        /// A music prompt. Deprecated. Use `composition_plan` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("music_prompt")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::ElevenLabs.MusicPrompt? MusicPrompt { get; set; }

        /// <summary>
        /// The lyrics text to use for the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics_text")]
        public string? LyricsText { get; set; }

        /// <summary>
        /// A detailed composition plan to guide music generation. Cannot be used in conjunction with `prompt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_plan")]
        public global::ElevenLabs.OneOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>? CompositionPlan { get; set; }

        /// <summary>
        /// The length of the song to generate in milliseconds. Used only in conjunction with `prompt`. Must be between 3000ms and 600000ms. Optional - if not provided, the model will choose a length based on the prompt.
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
        /// Random seed to initialize the music generation process. Providing the same seed with the same parameters can help achieve more consistent results, but exact reproducibility is not guaranteed and outputs may change across system updates. Cannot be used in conjunction with prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// If true, guarantees that the generated song will be instrumental. If false, the song may or may not be instrumental depending on the `prompt`. Can only be used with `prompt`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_instrumental")]
        public bool? ForceInstrumental { get; set; }

        /// <summary>
        /// The ID of the finetune to use for the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_id")]
        public string? FinetuneId { get; set; }

        /// <summary>
        /// How strongly the finetune influences the generation. Defaults to 1.0 (full strength). Lower values soften the influence of the finetune, leaving more room for prompt-level steering. Only meaningful when `finetune_id` is also provided.<br/>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_strength")]
        public double? FinetuneStrength { get; set; }

        /// <summary>
        /// If true, proper names in the prompt will be phonetically spelled in the lyrics for better pronunciation by the music model. The original names will be restored in word timestamps.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_phonetic_names")]
        public bool? UsePhoneticNames { get; set; }

        /// <summary>
        /// Controls how strictly section durations in the `composition_plan` are enforced. Only used with `composition_plan` and only applies to `music_v1`; for `music_v2` section durations are always enforced and this is ignored. When false for `music_v1`, the model may adjust individual section durations for better quality and latency, while preserving the total song duration from the plan.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respect_sections_durations")]
        public bool? RespectSectionsDurations { get; set; }

        /// <summary>
        /// Whether to store the generated song for inpainting.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_for_inpainting")]
        public bool? StoreForInpainting { get; set; }

        /// <summary>
        /// Whether to sign the generated song with C2PA. Applicable only for mp3 files.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sign_with_c2pa")]
        public bool? SignWithC2pa { get; set; }

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
        /// <param name="generationMode">
        /// Optional generation mode hint for prompt-based music generation. Can only be used with `prompt`.
        /// </param>
        /// <param name="lyricsText">
        /// The lyrics text to use for the generation.
        /// </param>
        /// <param name="compositionPlan">
        /// A detailed composition plan to guide music generation. Cannot be used in conjunction with `prompt`.
        /// </param>
        /// <param name="musicLengthMs">
        /// The length of the song to generate in milliseconds. Used only in conjunction with `prompt`. Must be between 3000ms and 600000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </param>
        /// <param name="seed">
        /// Random seed to initialize the music generation process. Providing the same seed with the same parameters can help achieve more consistent results, but exact reproducibility is not guaranteed and outputs may change across system updates. Cannot be used in conjunction with prompt.
        /// </param>
        /// <param name="forceInstrumental">
        /// If true, guarantees that the generated song will be instrumental. If false, the song may or may not be instrumental depending on the `prompt`. Can only be used with `prompt`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="finetuneId">
        /// The ID of the finetune to use for the generation
        /// </param>
        /// <param name="finetuneStrength">
        /// How strongly the finetune influences the generation. Defaults to 1.0 (full strength). Lower values soften the influence of the finetune, leaving more room for prompt-level steering. Only meaningful when `finetune_id` is also provided.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="usePhoneticNames">
        /// If true, proper names in the prompt will be phonetically spelled in the lyrics for better pronunciation by the music model. The original names will be restored in word timestamps.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="respectSectionsDurations">
        /// Controls how strictly section durations in the `composition_plan` are enforced. Only used with `composition_plan` and only applies to `music_v1`; for `music_v2` section durations are always enforced and this is ignored. When false for `music_v1`, the model may adjust individual section durations for better quality and latency, while preserving the total song duration from the plan.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="storeForInpainting">
        /// Whether to store the generated song for inpainting.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="signWithC2pa">
        /// Whether to sign the generated song with C2PA. Applicable only for mp3 files.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyComposeMusicV1MusicPost(
            string? prompt,
            global::ElevenLabs.MusicGenerationMode? generationMode,
            string? lyricsText,
            global::ElevenLabs.OneOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>? compositionPlan,
            int? musicLengthMs,
            global::ElevenLabs.BodyComposeMusicV1MusicPostModelId? modelId,
            int? seed,
            bool? forceInstrumental,
            string? finetuneId,
            double? finetuneStrength,
            bool? usePhoneticNames,
            bool? respectSectionsDurations,
            bool? storeForInpainting,
            bool? signWithC2pa)
        {
            this.Prompt = prompt;
            this.GenerationMode = generationMode;
            this.LyricsText = lyricsText;
            this.CompositionPlan = compositionPlan;
            this.MusicLengthMs = musicLengthMs;
            this.ModelId = modelId;
            this.Seed = seed;
            this.ForceInstrumental = forceInstrumental;
            this.FinetuneId = finetuneId;
            this.FinetuneStrength = finetuneStrength;
            this.UsePhoneticNames = usePhoneticNames;
            this.RespectSectionsDurations = respectSectionsDurations;
            this.StoreForInpainting = storeForInpainting;
            this.SignWithC2pa = signWithC2pa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyComposeMusicV1MusicPost" /> class.
        /// </summary>
        public BodyComposeMusicV1MusicPost()
        {
        }

    }
}