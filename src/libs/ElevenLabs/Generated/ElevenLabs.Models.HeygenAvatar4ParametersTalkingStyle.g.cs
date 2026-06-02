
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: stable
    /// </summary>
    public enum HeygenAvatar4ParametersTalkingStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Expressive,
        /// <summary>
        /// 
        /// </summary>
        Stable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HeygenAvatar4ParametersTalkingStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeygenAvatar4ParametersTalkingStyle value)
        {
            return value switch
            {
                HeygenAvatar4ParametersTalkingStyle.Expressive => "expressive",
                HeygenAvatar4ParametersTalkingStyle.Stable => "stable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeygenAvatar4ParametersTalkingStyle? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => HeygenAvatar4ParametersTalkingStyle.Expressive,
                "stable" => HeygenAvatar4ParametersTalkingStyle.Stable,
                _ => null,
            };
        }
    }
}