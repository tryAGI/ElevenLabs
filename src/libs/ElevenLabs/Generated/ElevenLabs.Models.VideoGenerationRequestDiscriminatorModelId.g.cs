
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoGenerationRequestDiscriminatorModelId
    {
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
        BytedanceSeedanceV2Mini,
        /// <summary>
        ///
        /// </summary>
        BytedanceSeedanceV25,
        /// <summary>
        ///
        /// </summary>
        CreatifyAurora,
        /// <summary>
        ///
        /// </summary>
        Veo31FastGenerate001,
        /// <summary>
        ///
        /// </summary>
        Veo31Generate001,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoGenerationRequestDiscriminatorModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGenerationRequestDiscriminatorModelId value)
        {
            return value switch
            {
                VideoGenerationRequestDiscriminatorModelId.BytedanceSeedanceV2 => "bytedance-seedance-v2",
                VideoGenerationRequestDiscriminatorModelId.BytedanceSeedanceV2Fast => "bytedance-seedance-v2-fast",
                VideoGenerationRequestDiscriminatorModelId.BytedanceSeedanceV2Mini => "bytedance-seedance-v2-mini",
                VideoGenerationRequestDiscriminatorModelId.BytedanceSeedanceV25 => "bytedance-seedance-v2.5",
                VideoGenerationRequestDiscriminatorModelId.CreatifyAurora => "creatify-aurora",
                VideoGenerationRequestDiscriminatorModelId.Veo31FastGenerate001 => "veo-3.1-fast-generate-001",
                VideoGenerationRequestDiscriminatorModelId.Veo31Generate001 => "veo-3.1-generate-001",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGenerationRequestDiscriminatorModelId? ToEnum(string value)
        {
            return value switch
            {
                "bytedance-seedance-v2" => VideoGenerationRequestDiscriminatorModelId.BytedanceSeedanceV2,
                "bytedance-seedance-v2-fast" => VideoGenerationRequestDiscriminatorModelId.BytedanceSeedanceV2Fast,
                "bytedance-seedance-v2-mini" => VideoGenerationRequestDiscriminatorModelId.BytedanceSeedanceV2Mini,
                "bytedance-seedance-v2.5" => VideoGenerationRequestDiscriminatorModelId.BytedanceSeedanceV25,
                "creatify-aurora" => VideoGenerationRequestDiscriminatorModelId.CreatifyAurora,
                "veo-3.1-fast-generate-001" => VideoGenerationRequestDiscriminatorModelId.Veo31FastGenerate001,
                "veo-3.1-generate-001" => VideoGenerationRequestDiscriminatorModelId.Veo31Generate001,
                _ => null,
            };
        }
    }
}