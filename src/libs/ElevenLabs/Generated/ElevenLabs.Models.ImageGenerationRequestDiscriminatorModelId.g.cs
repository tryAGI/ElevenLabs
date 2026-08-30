
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageGenerationRequestDiscriminatorModelId
    {
        /// <summary>
        ///
        /// </summary>
        BytedanceSeedream5Lite,
        /// <summary>
        ///
        /// </summary>
        BytedanceSeedream5Pro,
        /// <summary>
        ///
        /// </summary>
        Gemini25FlashImage,
        /// <summary>
        ///
        /// </summary>
        Gemini3ProImage,
        /// <summary>
        ///
        /// </summary>
        Gemini31FlashImage,
        /// <summary>
        ///
        /// </summary>
        Gemini31FlashLiteImage,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestDiscriminatorModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestDiscriminatorModelId value)
        {
            return value switch
            {
                ImageGenerationRequestDiscriminatorModelId.BytedanceSeedream5Lite => "bytedance-seedream-5-lite",
                ImageGenerationRequestDiscriminatorModelId.BytedanceSeedream5Pro => "bytedance-seedream-5-pro",
                ImageGenerationRequestDiscriminatorModelId.Gemini25FlashImage => "gemini-2.5-flash-image",
                ImageGenerationRequestDiscriminatorModelId.Gemini3ProImage => "gemini-3-pro-image",
                ImageGenerationRequestDiscriminatorModelId.Gemini31FlashImage => "gemini-3.1-flash-image",
                ImageGenerationRequestDiscriminatorModelId.Gemini31FlashLiteImage => "gemini-3.1-flash-lite-image",
                ImageGenerationRequestDiscriminatorModelId.GptImage1 => "gpt-image-1",
                ImageGenerationRequestDiscriminatorModelId.GptImage15 => "gpt-image-1.5",
                ImageGenerationRequestDiscriminatorModelId.GptImage2 => "gpt-image-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestDiscriminatorModelId? ToEnum(string value)
        {
            return value switch
            {
                "bytedance-seedream-5-lite" => ImageGenerationRequestDiscriminatorModelId.BytedanceSeedream5Lite,
                "bytedance-seedream-5-pro" => ImageGenerationRequestDiscriminatorModelId.BytedanceSeedream5Pro,
                "gemini-2.5-flash-image" => ImageGenerationRequestDiscriminatorModelId.Gemini25FlashImage,
                "gemini-3-pro-image" => ImageGenerationRequestDiscriminatorModelId.Gemini3ProImage,
                "gemini-3.1-flash-image" => ImageGenerationRequestDiscriminatorModelId.Gemini31FlashImage,
                "gemini-3.1-flash-lite-image" => ImageGenerationRequestDiscriminatorModelId.Gemini31FlashLiteImage,
                "gpt-image-1" => ImageGenerationRequestDiscriminatorModelId.GptImage1,
                "gpt-image-1.5" => ImageGenerationRequestDiscriminatorModelId.GptImage15,
                "gpt-image-2" => ImageGenerationRequestDiscriminatorModelId.GptImage2,
                _ => null,
            };
        }
    }
}