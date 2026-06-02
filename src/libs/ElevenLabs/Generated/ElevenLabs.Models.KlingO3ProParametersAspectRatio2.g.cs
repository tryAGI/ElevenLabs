
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum KlingO3ProParametersAspectRatio2
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
    public static class KlingO3ProParametersAspectRatio2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KlingO3ProParametersAspectRatio2 value)
        {
            return value switch
            {
                KlingO3ProParametersAspectRatio2.x16_9 => "16:9",
                KlingO3ProParametersAspectRatio2.x1_1 => "1:1",
                KlingO3ProParametersAspectRatio2.x9_16 => "9:16",
                KlingO3ProParametersAspectRatio2.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KlingO3ProParametersAspectRatio2? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => KlingO3ProParametersAspectRatio2.x16_9,
                "1:1" => KlingO3ProParametersAspectRatio2.x1_1,
                "9:16" => KlingO3ProParametersAspectRatio2.x9_16,
                "auto" => KlingO3ProParametersAspectRatio2.Auto,
                _ => null,
            };
        }
    }
}