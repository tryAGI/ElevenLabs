
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 1K
    /// </summary>
    public enum GeminiImageProParametersResolution
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeminiImageProParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeminiImageProParametersResolution value)
        {
            return value switch
            {
                GeminiImageProParametersResolution.x1k => "1K",
                GeminiImageProParametersResolution.x2k => "2K",
                GeminiImageProParametersResolution.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeminiImageProParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => GeminiImageProParametersResolution.x1k,
                "2K" => GeminiImageProParametersResolution.x2k,
                "4K" => GeminiImageProParametersResolution.x4k,
                _ => null,
            };
        }
    }
}