
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceDesignRequestModel
    {
        /// <summary>
        /// Description to use for the created voice.<br/>
        /// Example: A sassy squeaky mouse
        /// </summary>
        /// <example>A sassy squeaky mouse</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceDescription { get; set; }

        /// <summary>
        /// Model to use for the voice generation. Possible values: eleven_multilingual_ttv_v2, eleven_ttv_v3.<br/>
        /// Default Value: eleven_multilingual_ttv_v2<br/>
        /// Example: eleven_multilingual_ttv_v2
        /// </summary>
        /// <example>eleven_multilingual_ttv_v2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.VoiceDesignRequestModelModelIdJsonConverter))]
        public global::ElevenLabs.VoiceDesignRequestModelModelId? ModelId { get; set; }

        /// <summary>
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </summary>
        /// <example>Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Whether to automatically generate a text suitable for the voice description.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_generate_text")]
        public bool? AutoGenerateText { get; set; }

        /// <summary>
        /// Controls the volume level of the generated voice. -1 is quietest, 1 is loudest, 0 corresponds to roughly -24 LUFS.<br/>
        /// Default Value: 0.5<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness")]
        public double? Loudness { get; set; }

        /// <summary>
        /// Random number that controls the voice generation. Same seed with same inputs produces same voice.<br/>
        /// Example: 11
        /// </summary>
        /// <example>11</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Controls how closely the AI follows the prompt. Lower numbers give the AI more freedom to be creative, while higher numbers force it to stick more to the prompt. High numbers can cause voice to sound artificial or robotic. We recommend to use longer, more detailed prompts at lower Guidance Scale.<br/>
        /// Default Value: 5<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// Higher quality results in better voice output but less variety.<br/>
        /// Example: 0.9
        /// </summary>
        /// <example>0.9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public double? Quality { get; set; }

        /// <summary>
        /// Reference audio to use for the voice generation. The audio should be base64 encoded. Only supported when using the  eleven_ttv_v3 model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_audio_base64")]
        public string? ReferenceAudioBase64 { get; set; }

        /// <summary>
        /// Controls the balance of prompt versus reference audio when generating voice samples. 0 means almost no prompt influence, 1 means almost no reference audio influence. Only supported when using the eleven_ttv_v3 model and providing reference audio.<br/>
        /// Example: 0.25
        /// </summary>
        /// <example>0.25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_strength")]
        public double? PromptStrength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignRequestModel" /> class.
        /// </summary>
        /// <param name="voiceDescription">
        /// Description to use for the created voice.<br/>
        /// Example: A sassy squeaky mouse
        /// </param>
        /// <param name="modelId">
        /// Model to use for the voice generation. Possible values: eleven_multilingual_ttv_v2, eleven_ttv_v3.<br/>
        /// Default Value: eleven_multilingual_ttv_v2<br/>
        /// Example: eleven_multilingual_ttv_v2
        /// </param>
        /// <param name="text">
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </param>
        /// <param name="autoGenerateText">
        /// Whether to automatically generate a text suitable for the voice description.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="loudness">
        /// Controls the volume level of the generated voice. -1 is quietest, 1 is loudest, 0 corresponds to roughly -24 LUFS.<br/>
        /// Default Value: 0.5<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="seed">
        /// Random number that controls the voice generation. Same seed with same inputs produces same voice.<br/>
        /// Example: 11
        /// </param>
        /// <param name="guidanceScale">
        /// Controls how closely the AI follows the prompt. Lower numbers give the AI more freedom to be creative, while higher numbers force it to stick more to the prompt. High numbers can cause voice to sound artificial or robotic. We recommend to use longer, more detailed prompts at lower Guidance Scale.<br/>
        /// Default Value: 5<br/>
        /// Example: 5
        /// </param>
        /// <param name="quality">
        /// Higher quality results in better voice output but less variety.<br/>
        /// Example: 0.9
        /// </param>
        /// <param name="referenceAudioBase64">
        /// Reference audio to use for the voice generation. The audio should be base64 encoded. Only supported when using the  eleven_ttv_v3 model.
        /// </param>
        /// <param name="promptStrength">
        /// Controls the balance of prompt versus reference audio when generating voice samples. 0 means almost no prompt influence, 1 means almost no reference audio influence. Only supported when using the eleven_ttv_v3 model and providing reference audio.<br/>
        /// Example: 0.25
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceDesignRequestModel(
            string voiceDescription,
            global::ElevenLabs.VoiceDesignRequestModelModelId? modelId,
            string? text,
            bool? autoGenerateText,
            double? loudness,
            int? seed,
            double? guidanceScale,
            double? quality,
            string? referenceAudioBase64,
            double? promptStrength)
        {
            this.VoiceDescription = voiceDescription ?? throw new global::System.ArgumentNullException(nameof(voiceDescription));
            this.ModelId = modelId;
            this.Text = text;
            this.AutoGenerateText = autoGenerateText;
            this.Loudness = loudness;
            this.Seed = seed;
            this.GuidanceScale = guidanceScale;
            this.Quality = quality;
            this.ReferenceAudioBase64 = referenceAudioBase64;
            this.PromptStrength = promptStrength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignRequestModel" /> class.
        /// </summary>
        public VoiceDesignRequestModel()
        {
        }
    }
}