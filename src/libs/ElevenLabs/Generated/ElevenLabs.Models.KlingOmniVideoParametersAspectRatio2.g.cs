
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum KlingOmniVideoParametersAspectRatio2
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KlingOmniVideoParametersAspectRatio2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KlingOmniVideoParametersAspectRatio2 value)
        {
            return value switch
            {
                KlingOmniVideoParametersAspectRatio2.x16_9 => "16:9",
                KlingOmniVideoParametersAspectRatio2.x1_1 => "1:1",
                KlingOmniVideoParametersAspectRatio2.x9_16 => "9:16",
                KlingOmniVideoParametersAspectRatio2.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KlingOmniVideoParametersAspectRatio2? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => KlingOmniVideoParametersAspectRatio2.x16_9,
                "1:1" => KlingOmniVideoParametersAspectRatio2.x1_1,
                "9:16" => KlingOmniVideoParametersAspectRatio2.x9_16,
                "auto" => KlingOmniVideoParametersAspectRatio2.Auto,
                _ => null,
            };
        }
    }
}