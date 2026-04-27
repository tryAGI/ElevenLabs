
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelID
    {
        /// <summary>
        /// 
        /// </summary>
        BirefnetV2BgRemoval,
        /// <summary>
        /// 
        /// </summary>
        BytedanceOmnihumanV15,
        /// <summary>
        /// 
        /// </summary>
        BytedanceSeedanceV1Pro,
        /// <summary>
        /// 
        /// </summary>
        BytedanceSeedanceV15Pro,
        /// <summary>
        /// 
        /// </summary>
        BytedanceSeedanceV2,
        /// <summary>
        /// 
        /// </summary>
        BytedanceSeedanceV2Fast,
        /// <summary>
        /// 
        /// </summary>
        BytedanceSeedream4,
        /// <summary>
        /// 
        /// </summary>
        BytedanceSeedream45,
        /// <summary>
        /// 
        /// </summary>
        BytedanceSeedream5Lite,
        /// <summary>
        /// 
        /// </summary>
        CreatifyAurora,
        /// <summary>
        /// 
        /// </summary>
        ElevenComposition,
        /// <summary>
        /// 
        /// </summary>
        ElevenMultilingualV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenMusicV1,
        /// <summary>
        /// 
        /// </summary>
        ElevenTextToSoundV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenTurboV25,
        /// <summary>
        /// 
        /// </summary>
        ElevenV3,
        /// <summary>
        /// 
        /// </summary>
        Flux1Kontext,
        /// <summary>
        /// 
        /// </summary>
        Flux2Pro,
        /// <summary>
        /// 
        /// </summary>
        Gemini25FlashImage,
        /// <summary>
        /// 
        /// </summary>
        Gemini25FlashLiteLlm,
        /// <summary>
        /// 
        /// </summary>
        Gemini25FlashLlm,
        /// <summary>
        /// 
        /// </summary>
        Gemini3ProImagePreview,
        /// <summary>
        /// 
        /// </summary>
        Gemini31FlashImagePreview,
        /// <summary>
        /// 
        /// </summary>
        GptImage1,
        /// <summary>
        /// 
        /// </summary>
        GptImage15,
        /// <summary>
        /// 
        /// </summary>
        GptImage2,
        /// <summary>
        /// 
        /// </summary>
        Imagen4,
        /// <summary>
        /// 
        /// </summary>
        Imagen4Fast,
        /// <summary>
        /// 
        /// </summary>
        Imagen4Ultra,
        /// <summary>
        /// 
        /// </summary>
        Kling25Turbo,
        /// <summary>
        /// 
        /// </summary>
        Kling26Pro,
        /// <summary>
        /// 
        /// </summary>
        Kling26ProMotionControl,
        /// <summary>
        /// 
        /// </summary>
        Kling3Pro,
        /// <summary>
        /// 
        /// </summary>
        Kling3ProMotionControl,
        /// <summary>
        /// 
        /// </summary>
        KlingO3Pro,
        /// <summary>
        /// 
        /// </summary>
        KlingOmniEditVideo,
        /// <summary>
        /// 
        /// </summary>
        KlingOmniImage,
        /// <summary>
        /// 
        /// </summary>
        KlingOmniVideo,
        /// <summary>
        /// 
        /// </summary>
        LtxAudioToVideo,
        /// <summary>
        /// 
        /// </summary>
        LtxV2,
        /// <summary>
        /// 
        /// </summary>
        LtxV2Fast,
        /// <summary>
        /// 
        /// </summary>
        LtxV2Retake,
        /// <summary>
        /// 
        /// </summary>
        RunwayActTwo,
        /// <summary>
        /// 
        /// </summary>
        RunwayGen45,
        /// <summary>
        /// 
        /// </summary>
        RunwayGen4Aleph,
        /// <summary>
        /// 
        /// </summary>
        RunwayGen4Image,
        /// <summary>
        /// 
        /// </summary>
        RunwayGen4ImageTurbo,
        /// <summary>
        /// 
        /// </summary>
        RunwayGen4Turbo,
        /// <summary>
        /// 
        /// </summary>
        Sora2,
        /// <summary>
        /// 
        /// </summary>
        Sora2Pro,
        /// <summary>
        /// 
        /// </summary>
        SyncLipsyncV2Pro,
        /// <summary>
        /// 
        /// </summary>
        SyncLipsyncV3,
        /// <summary>
        /// 
        /// </summary>
        TestImage,
        /// <summary>
        /// 
        /// </summary>
        TestVideo,
        /// <summary>
        /// 
        /// </summary>
        TopazImageUpscale,
        /// <summary>
        /// 
        /// </summary>
        TopazVideoUpscale,
        /// <summary>
        /// 
        /// </summary>
        VeedFabric1Fast,
        /// <summary>
        /// 
        /// </summary>
        VeedLipsync,
        /// <summary>
        /// 
        /// </summary>
        Veo20Generate001,
        /// <summary>
        /// 
        /// </summary>
        Veo20GenerateExp,
        /// <summary>
        /// 
        /// </summary>
        Veo30FastGenerate001,
        /// <summary>
        /// 
        /// </summary>
        Veo30FastGeneratePreview,
        /// <summary>
        /// 
        /// </summary>
        Veo30Generate001,
        /// <summary>
        /// 
        /// </summary>
        Veo30GeneratePreview,
        /// <summary>
        /// 
        /// </summary>
        Veo31FastGenerate001,
        /// <summary>
        /// 
        /// </summary>
        Veo31FastGeneratePreview,
        /// <summary>
        /// 
        /// </summary>
        Veo31Generate001,
        /// <summary>
        /// 
        /// </summary>
        Veo31GeneratePreview,
        /// <summary>
        /// 
        /// </summary>
        Veo31LiteGenerate001,
        /// <summary>
        /// 
        /// </summary>
        Wan25PreviewImage,
        /// <summary>
        /// 
        /// </summary>
        Wan25PreviewVideo,
        /// <summary>
        /// 
        /// </summary>
        Wan26,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelIDExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelID value)
        {
            return value switch
            {
                ModelID.BirefnetV2BgRemoval => "birefnet-v2-bg-removal",
                ModelID.BytedanceOmnihumanV15 => "bytedance-omnihuman-v1.5",
                ModelID.BytedanceSeedanceV1Pro => "bytedance-seedance-v1-pro",
                ModelID.BytedanceSeedanceV15Pro => "bytedance-seedance-v1.5-pro",
                ModelID.BytedanceSeedanceV2 => "bytedance-seedance-v2",
                ModelID.BytedanceSeedanceV2Fast => "bytedance-seedance-v2-fast",
                ModelID.BytedanceSeedream4 => "bytedance-seedream-4",
                ModelID.BytedanceSeedream45 => "bytedance-seedream-4.5",
                ModelID.BytedanceSeedream5Lite => "bytedance-seedream-5-lite",
                ModelID.CreatifyAurora => "creatify-aurora",
                ModelID.ElevenComposition => "eleven_composition",
                ModelID.ElevenMultilingualV2 => "eleven_multilingual_v2",
                ModelID.ElevenMusicV1 => "eleven_music_v1",
                ModelID.ElevenTextToSoundV2 => "eleven_text_to_sound_v2",
                ModelID.ElevenTurboV25 => "eleven_turbo_v2_5",
                ModelID.ElevenV3 => "eleven_v3",
                ModelID.Flux1Kontext => "flux-1-kontext",
                ModelID.Flux2Pro => "flux-2-pro",
                ModelID.Gemini25FlashImage => "gemini-2.5-flash-image",
                ModelID.Gemini25FlashLiteLlm => "gemini-2.5-flash-lite-llm",
                ModelID.Gemini25FlashLlm => "gemini-2.5-flash-llm",
                ModelID.Gemini3ProImagePreview => "gemini-3-pro-image-preview",
                ModelID.Gemini31FlashImagePreview => "gemini-3.1-flash-image-preview",
                ModelID.GptImage1 => "gpt-image-1",
                ModelID.GptImage15 => "gpt-image-1.5",
                ModelID.GptImage2 => "gpt-image-2",
                ModelID.Imagen4 => "imagen-4",
                ModelID.Imagen4Fast => "imagen-4-fast",
                ModelID.Imagen4Ultra => "imagen-4-ultra",
                ModelID.Kling25Turbo => "kling-2.5-turbo",
                ModelID.Kling26Pro => "kling-2.6-pro",
                ModelID.Kling26ProMotionControl => "kling-2.6-pro-motion-control",
                ModelID.Kling3Pro => "kling-3-pro",
                ModelID.Kling3ProMotionControl => "kling-3-pro-motion-control",
                ModelID.KlingO3Pro => "kling-o3-pro",
                ModelID.KlingOmniEditVideo => "kling-omni-edit-video",
                ModelID.KlingOmniImage => "kling-omni-image",
                ModelID.KlingOmniVideo => "kling-omni-video",
                ModelID.LtxAudioToVideo => "ltx-audio-to-video",
                ModelID.LtxV2 => "ltx-v2",
                ModelID.LtxV2Fast => "ltx-v2-fast",
                ModelID.LtxV2Retake => "ltx-v2-retake",
                ModelID.RunwayActTwo => "runway-act-two",
                ModelID.RunwayGen45 => "runway-gen4-5",
                ModelID.RunwayGen4Aleph => "runway-gen4-aleph",
                ModelID.RunwayGen4Image => "runway-gen4-image",
                ModelID.RunwayGen4ImageTurbo => "runway-gen4-image-turbo",
                ModelID.RunwayGen4Turbo => "runway-gen4-turbo",
                ModelID.Sora2 => "sora-2",
                ModelID.Sora2Pro => "sora-2-pro",
                ModelID.SyncLipsyncV2Pro => "sync-lipsync-v2-pro",
                ModelID.SyncLipsyncV3 => "sync-lipsync-v3",
                ModelID.TestImage => "test-image",
                ModelID.TestVideo => "test-video",
                ModelID.TopazImageUpscale => "topaz-image-upscale",
                ModelID.TopazVideoUpscale => "topaz-video-upscale",
                ModelID.VeedFabric1Fast => "veed-fabric-1-fast",
                ModelID.VeedLipsync => "veed-lipsync",
                ModelID.Veo20Generate001 => "veo-2.0-generate-001",
                ModelID.Veo20GenerateExp => "veo-2.0-generate-exp",
                ModelID.Veo30FastGenerate001 => "veo-3.0-fast-generate-001",
                ModelID.Veo30FastGeneratePreview => "veo-3.0-fast-generate-preview",
                ModelID.Veo30Generate001 => "veo-3.0-generate-001",
                ModelID.Veo30GeneratePreview => "veo-3.0-generate-preview",
                ModelID.Veo31FastGenerate001 => "veo-3.1-fast-generate-001",
                ModelID.Veo31FastGeneratePreview => "veo-3.1-fast-generate-preview",
                ModelID.Veo31Generate001 => "veo-3.1-generate-001",
                ModelID.Veo31GeneratePreview => "veo-3.1-generate-preview",
                ModelID.Veo31LiteGenerate001 => "veo-3.1-lite-generate-001",
                ModelID.Wan25PreviewImage => "wan-2.5-preview-image",
                ModelID.Wan25PreviewVideo => "wan-2.5-preview-video",
                ModelID.Wan26 => "wan-2.6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelID? ToEnum(string value)
        {
            return value switch
            {
                "birefnet-v2-bg-removal" => ModelID.BirefnetV2BgRemoval,
                "bytedance-omnihuman-v1.5" => ModelID.BytedanceOmnihumanV15,
                "bytedance-seedance-v1-pro" => ModelID.BytedanceSeedanceV1Pro,
                "bytedance-seedance-v1.5-pro" => ModelID.BytedanceSeedanceV15Pro,
                "bytedance-seedance-v2" => ModelID.BytedanceSeedanceV2,
                "bytedance-seedance-v2-fast" => ModelID.BytedanceSeedanceV2Fast,
                "bytedance-seedream-4" => ModelID.BytedanceSeedream4,
                "bytedance-seedream-4.5" => ModelID.BytedanceSeedream45,
                "bytedance-seedream-5-lite" => ModelID.BytedanceSeedream5Lite,
                "creatify-aurora" => ModelID.CreatifyAurora,
                "eleven_composition" => ModelID.ElevenComposition,
                "eleven_multilingual_v2" => ModelID.ElevenMultilingualV2,
                "eleven_music_v1" => ModelID.ElevenMusicV1,
                "eleven_text_to_sound_v2" => ModelID.ElevenTextToSoundV2,
                "eleven_turbo_v2_5" => ModelID.ElevenTurboV25,
                "eleven_v3" => ModelID.ElevenV3,
                "flux-1-kontext" => ModelID.Flux1Kontext,
                "flux-2-pro" => ModelID.Flux2Pro,
                "gemini-2.5-flash-image" => ModelID.Gemini25FlashImage,
                "gemini-2.5-flash-lite-llm" => ModelID.Gemini25FlashLiteLlm,
                "gemini-2.5-flash-llm" => ModelID.Gemini25FlashLlm,
                "gemini-3-pro-image-preview" => ModelID.Gemini3ProImagePreview,
                "gemini-3.1-flash-image-preview" => ModelID.Gemini31FlashImagePreview,
                "gpt-image-1" => ModelID.GptImage1,
                "gpt-image-1.5" => ModelID.GptImage15,
                "gpt-image-2" => ModelID.GptImage2,
                "imagen-4" => ModelID.Imagen4,
                "imagen-4-fast" => ModelID.Imagen4Fast,
                "imagen-4-ultra" => ModelID.Imagen4Ultra,
                "kling-2.5-turbo" => ModelID.Kling25Turbo,
                "kling-2.6-pro" => ModelID.Kling26Pro,
                "kling-2.6-pro-motion-control" => ModelID.Kling26ProMotionControl,
                "kling-3-pro" => ModelID.Kling3Pro,
                "kling-3-pro-motion-control" => ModelID.Kling3ProMotionControl,
                "kling-o3-pro" => ModelID.KlingO3Pro,
                "kling-omni-edit-video" => ModelID.KlingOmniEditVideo,
                "kling-omni-image" => ModelID.KlingOmniImage,
                "kling-omni-video" => ModelID.KlingOmniVideo,
                "ltx-audio-to-video" => ModelID.LtxAudioToVideo,
                "ltx-v2" => ModelID.LtxV2,
                "ltx-v2-fast" => ModelID.LtxV2Fast,
                "ltx-v2-retake" => ModelID.LtxV2Retake,
                "runway-act-two" => ModelID.RunwayActTwo,
                "runway-gen4-5" => ModelID.RunwayGen45,
                "runway-gen4-aleph" => ModelID.RunwayGen4Aleph,
                "runway-gen4-image" => ModelID.RunwayGen4Image,
                "runway-gen4-image-turbo" => ModelID.RunwayGen4ImageTurbo,
                "runway-gen4-turbo" => ModelID.RunwayGen4Turbo,
                "sora-2" => ModelID.Sora2,
                "sora-2-pro" => ModelID.Sora2Pro,
                "sync-lipsync-v2-pro" => ModelID.SyncLipsyncV2Pro,
                "sync-lipsync-v3" => ModelID.SyncLipsyncV3,
                "test-image" => ModelID.TestImage,
                "test-video" => ModelID.TestVideo,
                "topaz-image-upscale" => ModelID.TopazImageUpscale,
                "topaz-video-upscale" => ModelID.TopazVideoUpscale,
                "veed-fabric-1-fast" => ModelID.VeedFabric1Fast,
                "veed-lipsync" => ModelID.VeedLipsync,
                "veo-2.0-generate-001" => ModelID.Veo20Generate001,
                "veo-2.0-generate-exp" => ModelID.Veo20GenerateExp,
                "veo-3.0-fast-generate-001" => ModelID.Veo30FastGenerate001,
                "veo-3.0-fast-generate-preview" => ModelID.Veo30FastGeneratePreview,
                "veo-3.0-generate-001" => ModelID.Veo30Generate001,
                "veo-3.0-generate-preview" => ModelID.Veo30GeneratePreview,
                "veo-3.1-fast-generate-001" => ModelID.Veo31FastGenerate001,
                "veo-3.1-fast-generate-preview" => ModelID.Veo31FastGeneratePreview,
                "veo-3.1-generate-001" => ModelID.Veo31Generate001,
                "veo-3.1-generate-preview" => ModelID.Veo31GeneratePreview,
                "veo-3.1-lite-generate-001" => ModelID.Veo31LiteGenerate001,
                "wan-2.5-preview-image" => ModelID.Wan25PreviewImage,
                "wan-2.5-preview-video" => ModelID.Wan25PreviewVideo,
                "wan-2.6" => ModelID.Wan26,
                _ => null,
            };
        }
    }
}