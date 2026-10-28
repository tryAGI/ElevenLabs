
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: closed
    /// </summary>
    public enum HolidayType
    {
        /// <summary>
        ///
        /// </summary>
        Closed,
        /// <summary>
        ///
        /// </summary>
        Override,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HolidayTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HolidayType value)
        {
            return value switch
            {
                HolidayType.Closed => "closed",
                HolidayType.Override => "override",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HolidayType? ToEnum(string value)
        {
            return value switch
            {
                "closed" => HolidayType.Closed,
                "override" => HolidayType.Override,
                _ => null,
            };
        }
    }
}