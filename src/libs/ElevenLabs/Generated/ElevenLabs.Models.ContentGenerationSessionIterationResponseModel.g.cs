
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentGenerationSessionIterationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_prompt")]
        public object? DisplayPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ContentGenerationStatusUpdateResponseModel> Generations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.Veo3Parameters, global::ElevenLabs.Veo2Parameters, global::ElevenLabs.Veo2ExpParameters, global::ElevenLabs.Veo31Parameters, global::ElevenLabs.Veo31FastParameters, global::ElevenLabs.Veo31LiteParameters, global::ElevenLabs.GeminiImageParameters, global::ElevenLabs.GeminiImageProParameters, global::ElevenLabs.Gemini31FlashImageParameters, global::ElevenLabs.Imagen4FastParameters, global::ElevenLabs.Imagen4Parameters, global::ElevenLabs.Sora2Parameters, global::ElevenLabs.Sora2ProParameters, global::ElevenLabs.GPTImageParameters, global::ElevenLabs.GPTImage2Parameters, global::ElevenLabs.Kling25TurboParameters, global::ElevenLabs.Kling26ProParameters, global::ElevenLabs.KlingOmniVideoParameters, global::ElevenLabs.KlingOmniImageParameters, global::ElevenLabs.KlingO3ProParameters, global::ElevenLabs.Kling3ProParameters, global::ElevenLabs.Flux1KontextParameters, global::ElevenLabs.Flux2ProParameters, global::ElevenLabs.KreaV2Parameters, global::ElevenLabs.BytedanceSeedanceParameters, global::ElevenLabs.BytedanceSeedance15ProParameters, global::ElevenLabs.BytedanceSeedance2Parameters, global::ElevenLabs.BytedanceSeedance2FastParameters, global::ElevenLabs.BytedanceSeedream4Parameters, global::ElevenLabs.BytedanceSeedream45Parameters, global::ElevenLabs.BytedanceSeedream5LiteParameters, global::ElevenLabs.Wan25PreviewImageParameters, global::ElevenLabs.Wan25PreviewVideoParameters, global::ElevenLabs.Wan26Parameters, global::ElevenLabs.LTXV2Parameters, global::ElevenLabs.LTXV2FastParameters, global::ElevenLabs.RunwayGen45Parameters, global::ElevenLabs.RunwayGen4ImageParameters, global::ElevenLabs.TestParameters, global::ElevenLabs.ElevenLabsTTSParameters, global::ElevenLabs.ElevenLabsSFXParameters, global::ElevenLabs.ElevenLabsMusicParameters, global::ElevenLabs.GeminiLLMParameters, global::ElevenLabs.ElevenLabsDubbingParameters, global::ElevenLabs.ElevenLabsCompositionParameters, global::ElevenLabs.ElevenLabsSTTParameters, global::ElevenLabs.Kling26ProMotionControlParameters, global::ElevenLabs.Kling3ProMotionControlParameters, global::ElevenLabs.KlingOmniEditVideoParameters, global::ElevenLabs.KlingO3EditVideoParameters, global::ElevenLabs.TopazImageUpscaleParameters, global::ElevenLabs.TopazVideoUpscaleParameters, global::ElevenLabs.BiRefNetBgRemovalParameters, global::ElevenLabs.SyncLipSyncParameters, global::ElevenLabs.SyncLipSyncV3Parameters, global::ElevenLabs.VeedLipSyncParameters, global::ElevenLabs.VeedFabricParameters, global::ElevenLabs.BytedanceOmniHumanParameters, global::ElevenLabs.CreatifyAuroraParameters, global::ElevenLabs.HeygenAvatar4Parameters, global::ElevenLabs.LTXV2RetakeParameters, global::ElevenLabs.LTXAudioToVideoParameters, global::ElevenLabs.RunwayGen4TurboParameters, global::ElevenLabs.RunwayGen4AlephParameters, global::ElevenLabs.RunwayActTwoParameters, global::ElevenLabs.RunwayGen4ImageTurboParameters, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnyOf<global::ElevenLabs.Veo3Parameters, global::ElevenLabs.Veo2Parameters, global::ElevenLabs.Veo2ExpParameters, global::ElevenLabs.Veo31Parameters, global::ElevenLabs.Veo31FastParameters, global::ElevenLabs.Veo31LiteParameters, global::ElevenLabs.GeminiImageParameters, global::ElevenLabs.GeminiImageProParameters, global::ElevenLabs.Gemini31FlashImageParameters, global::ElevenLabs.Imagen4FastParameters, global::ElevenLabs.Imagen4Parameters, global::ElevenLabs.Sora2Parameters, global::ElevenLabs.Sora2ProParameters, global::ElevenLabs.GPTImageParameters, global::ElevenLabs.GPTImage2Parameters, global::ElevenLabs.Kling25TurboParameters, global::ElevenLabs.Kling26ProParameters, global::ElevenLabs.KlingOmniVideoParameters, global::ElevenLabs.KlingOmniImageParameters, global::ElevenLabs.KlingO3ProParameters, global::ElevenLabs.Kling3ProParameters, global::ElevenLabs.Flux1KontextParameters, global::ElevenLabs.Flux2ProParameters, global::ElevenLabs.KreaV2Parameters, global::ElevenLabs.BytedanceSeedanceParameters, global::ElevenLabs.BytedanceSeedance15ProParameters, global::ElevenLabs.BytedanceSeedance2Parameters, global::ElevenLabs.BytedanceSeedance2FastParameters, global::ElevenLabs.BytedanceSeedream4Parameters, global::ElevenLabs.BytedanceSeedream45Parameters, global::ElevenLabs.BytedanceSeedream5LiteParameters, global::ElevenLabs.Wan25PreviewImageParameters, global::ElevenLabs.Wan25PreviewVideoParameters, global::ElevenLabs.Wan26Parameters, global::ElevenLabs.LTXV2Parameters, global::ElevenLabs.LTXV2FastParameters, global::ElevenLabs.RunwayGen45Parameters, global::ElevenLabs.RunwayGen4ImageParameters, global::ElevenLabs.TestParameters, global::ElevenLabs.ElevenLabsTTSParameters, global::ElevenLabs.ElevenLabsSFXParameters, global::ElevenLabs.ElevenLabsMusicParameters, global::ElevenLabs.GeminiLLMParameters, global::ElevenLabs.ElevenLabsDubbingParameters, global::ElevenLabs.ElevenLabsCompositionParameters, global::ElevenLabs.ElevenLabsSTTParameters, global::ElevenLabs.Kling26ProMotionControlParameters, global::ElevenLabs.Kling3ProMotionControlParameters, global::ElevenLabs.KlingOmniEditVideoParameters, global::ElevenLabs.KlingO3EditVideoParameters, global::ElevenLabs.TopazImageUpscaleParameters, global::ElevenLabs.TopazVideoUpscaleParameters, global::ElevenLabs.BiRefNetBgRemovalParameters, global::ElevenLabs.SyncLipSyncParameters, global::ElevenLabs.SyncLipSyncV3Parameters, global::ElevenLabs.VeedLipSyncParameters, global::ElevenLabs.VeedFabricParameters, global::ElevenLabs.BytedanceOmniHumanParameters, global::ElevenLabs.CreatifyAuroraParameters, global::ElevenLabs.HeygenAvatar4Parameters, global::ElevenLabs.LTXV2RetakeParameters, global::ElevenLabs.LTXAudioToVideoParameters, global::ElevenLabs.RunwayGen4TurboParameters, global::ElevenLabs.RunwayGen4AlephParameters, global::ElevenLabs.RunwayActTwoParameters, global::ElevenLabs.RunwayGen4ImageTurboParameters, object> ModelParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGenerationSessionIterationResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="generations"></param>
        /// <param name="modelParameters"></param>
        /// <param name="prompt"></param>
        /// <param name="displayPrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentGenerationSessionIterationResponseModel(
            string id,
            global::System.Collections.Generic.IList<global::ElevenLabs.ContentGenerationStatusUpdateResponseModel> generations,
            global::ElevenLabs.AnyOf<global::ElevenLabs.Veo3Parameters, global::ElevenLabs.Veo2Parameters, global::ElevenLabs.Veo2ExpParameters, global::ElevenLabs.Veo31Parameters, global::ElevenLabs.Veo31FastParameters, global::ElevenLabs.Veo31LiteParameters, global::ElevenLabs.GeminiImageParameters, global::ElevenLabs.GeminiImageProParameters, global::ElevenLabs.Gemini31FlashImageParameters, global::ElevenLabs.Imagen4FastParameters, global::ElevenLabs.Imagen4Parameters, global::ElevenLabs.Sora2Parameters, global::ElevenLabs.Sora2ProParameters, global::ElevenLabs.GPTImageParameters, global::ElevenLabs.GPTImage2Parameters, global::ElevenLabs.Kling25TurboParameters, global::ElevenLabs.Kling26ProParameters, global::ElevenLabs.KlingOmniVideoParameters, global::ElevenLabs.KlingOmniImageParameters, global::ElevenLabs.KlingO3ProParameters, global::ElevenLabs.Kling3ProParameters, global::ElevenLabs.Flux1KontextParameters, global::ElevenLabs.Flux2ProParameters, global::ElevenLabs.KreaV2Parameters, global::ElevenLabs.BytedanceSeedanceParameters, global::ElevenLabs.BytedanceSeedance15ProParameters, global::ElevenLabs.BytedanceSeedance2Parameters, global::ElevenLabs.BytedanceSeedance2FastParameters, global::ElevenLabs.BytedanceSeedream4Parameters, global::ElevenLabs.BytedanceSeedream45Parameters, global::ElevenLabs.BytedanceSeedream5LiteParameters, global::ElevenLabs.Wan25PreviewImageParameters, global::ElevenLabs.Wan25PreviewVideoParameters, global::ElevenLabs.Wan26Parameters, global::ElevenLabs.LTXV2Parameters, global::ElevenLabs.LTXV2FastParameters, global::ElevenLabs.RunwayGen45Parameters, global::ElevenLabs.RunwayGen4ImageParameters, global::ElevenLabs.TestParameters, global::ElevenLabs.ElevenLabsTTSParameters, global::ElevenLabs.ElevenLabsSFXParameters, global::ElevenLabs.ElevenLabsMusicParameters, global::ElevenLabs.GeminiLLMParameters, global::ElevenLabs.ElevenLabsDubbingParameters, global::ElevenLabs.ElevenLabsCompositionParameters, global::ElevenLabs.ElevenLabsSTTParameters, global::ElevenLabs.Kling26ProMotionControlParameters, global::ElevenLabs.Kling3ProMotionControlParameters, global::ElevenLabs.KlingOmniEditVideoParameters, global::ElevenLabs.KlingO3EditVideoParameters, global::ElevenLabs.TopazImageUpscaleParameters, global::ElevenLabs.TopazVideoUpscaleParameters, global::ElevenLabs.BiRefNetBgRemovalParameters, global::ElevenLabs.SyncLipSyncParameters, global::ElevenLabs.SyncLipSyncV3Parameters, global::ElevenLabs.VeedLipSyncParameters, global::ElevenLabs.VeedFabricParameters, global::ElevenLabs.BytedanceOmniHumanParameters, global::ElevenLabs.CreatifyAuroraParameters, global::ElevenLabs.HeygenAvatar4Parameters, global::ElevenLabs.LTXV2RetakeParameters, global::ElevenLabs.LTXAudioToVideoParameters, global::ElevenLabs.RunwayGen4TurboParameters, global::ElevenLabs.RunwayGen4AlephParameters, global::ElevenLabs.RunwayActTwoParameters, global::ElevenLabs.RunwayGen4ImageTurboParameters, object> modelParameters,
            string? prompt,
            object? displayPrompt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Prompt = prompt;
            this.DisplayPrompt = displayPrompt;
            this.Generations = generations ?? throw new global::System.ArgumentNullException(nameof(generations));
            this.ModelParameters = modelParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGenerationSessionIterationResponseModel" /> class.
        /// </summary>
        public ContentGenerationSessionIterationResponseModel()
        {
        }

    }
}