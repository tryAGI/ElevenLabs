
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextToSpeechGenerationRequestDiscriminatorModelId
    {
        /// <summary>
        /// 
        /// </summary>
        ElevenFlashV25,
        /// <summary>
        /// 
        /// </summary>
        ElevenMultilingualV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechGenerationRequestDiscriminatorModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechGenerationRequestDiscriminatorModelId value)
        {
            return value switch
            {
                TextToSpeechGenerationRequestDiscriminatorModelId.ElevenFlashV25 => "eleven_flash_v2_5",
                TextToSpeechGenerationRequestDiscriminatorModelId.ElevenMultilingualV2 => "eleven_multilingual_v2",
                TextToSpeechGenerationRequestDiscriminatorModelId.ElevenV3 => "eleven_v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechGenerationRequestDiscriminatorModelId? ToEnum(string value)
        {
            return value switch
            {
                "eleven_flash_v2_5" => TextToSpeechGenerationRequestDiscriminatorModelId.ElevenFlashV25,
                "eleven_multilingual_v2" => TextToSpeechGenerationRequestDiscriminatorModelId.ElevenMultilingualV2,
                "eleven_v3" => TextToSpeechGenerationRequestDiscriminatorModelId.ElevenV3,
                _ => null,
            };
        }
    }
}