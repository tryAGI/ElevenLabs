
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum AspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AspectRatio value)
        {
            return value switch
            {
                AspectRatio.x16_9 => "16:9",
                AspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => AspectRatio.x16_9,
                "9:16" => AspectRatio.x9_16,
                _ => null,
            };
        }
    }
}