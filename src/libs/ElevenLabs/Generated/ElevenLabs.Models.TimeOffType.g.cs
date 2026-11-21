
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// What a time-off entry blocks: a staff member, an asset, or a location.
    /// </summary>
    public enum TimeOffType
    {
        /// <summary>
        /// a staff member, an asset, or a location.
        /// </summary>
        Asset,
        /// <summary>
        /// a staff member, an asset, or a location.
        /// </summary>
        Location,
        /// <summary>
        /// a staff member, an asset, or a location.
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