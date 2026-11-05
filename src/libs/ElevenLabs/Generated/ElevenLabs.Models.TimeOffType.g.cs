
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TimeOffType
    {
        /// <summary>
        ///
        /// </summary>
        Asset,
        /// <summary>
        ///
        /// </summary>
        Location,
        /// <summary>
        ///
        /// </summary>
        Staff,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimeOffTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimeOffType value)
        {
            return value switch
            {
                TimeOffType.Asset => "asset",
                TimeOffType.Location => "location",
                TimeOffType.Staff => "staff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimeOffType? ToEnum(string value)
        {
            return value switch
            {
                "asset" => TimeOffType.Asset,
                "location" => TimeOffType.Location,
                "staff" => TimeOffType.Staff,
                _ => null,
            };
        }
    }
}