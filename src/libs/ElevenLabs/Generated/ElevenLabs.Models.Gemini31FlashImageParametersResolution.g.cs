
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 1K
    /// </summary>
    public enum Gemini31FlashImageParametersResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1k,
        /// <summary>
        /// 
        /// </summary>
        x2k,
        /// <summary>
        /// 
        /// </summary>
        x4k,
        /// <summary>
        /// 
        /// </summary>
        x512,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Gemini31FlashImageParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Gemini31FlashImageParametersResolution value)
        {
            return value switch
            {
                Gemini31FlashImageParametersResolution.x1k => "1K",
                Gemini31FlashImageParametersResolution.x2k => "2K",
                Gemini31FlashImageParametersResolution.x4k => "4K",
                Gemini31FlashImageParametersResolution.x512 => "512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Gemini31FlashImageParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => Gemini31FlashImageParametersResolution.x1k,
                "2K" => Gemini31FlashImageParametersResolution.x2k,
                "4K" => Gemini31FlashImageParametersResolution.x4k,
                "512" => Gemini31FlashImageParametersResolution.x512,
                _ => null,
            };
        }
    }
}