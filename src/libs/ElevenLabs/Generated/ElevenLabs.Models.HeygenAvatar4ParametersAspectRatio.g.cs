
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum HeygenAvatar4ParametersAspectRatio
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
    public static class HeygenAvatar4ParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeygenAvatar4ParametersAspectRatio value)
        {
            return value switch
            {
                HeygenAvatar4ParametersAspectRatio.x16_9 => "16:9",
                HeygenAvatar4ParametersAspectRatio.x1_1 => "1:1",
                HeygenAvatar4ParametersAspectRatio.x9_16 => "9:16",
                HeygenAvatar4ParametersAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeygenAvatar4ParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => HeygenAvatar4ParametersAspectRatio.x16_9,
                "1:1" => HeygenAvatar4ParametersAspectRatio.x1_1,
                "9:16" => HeygenAvatar4ParametersAspectRatio.x9_16,
                "auto" => HeygenAvatar4ParametersAspectRatio.Auto,
                _ => null,
            };
        }
    }
}