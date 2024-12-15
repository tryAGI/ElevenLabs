
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum BanReasonType
    {
        /// <summary>
        /// 
        /// </summary>
        Safety,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BanReasonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BanReasonType value)
        {
            return value switch
            {
                BanReasonType.Safety => "safety",
                BanReasonType.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BanReasonType? ToEnum(string value)
        {
            return value switch
            {
                "safety" => BanReasonType.Safety,
                "manual" => BanReasonType.Manual,
                _ => null,
            };
        }
    }
}