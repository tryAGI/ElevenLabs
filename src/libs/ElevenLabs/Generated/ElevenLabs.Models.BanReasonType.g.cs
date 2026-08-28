
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum BanReasonType
    {
        /// <summary>
        ///
        /// </summary>
        Manual,
        /// <summary>
        ///
        /// </summary>
        Safety,
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
                BanReasonType.Manual => "manual",
                BanReasonType.Safety => "safety",
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
                "manual" => BanReasonType.Manual,
                "safety" => BanReasonType.Safety,
                _ => null,
            };
        }
    }
}