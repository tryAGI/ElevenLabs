
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum PhoneNumberSortBy
    {
        /// <summary>
        ///
        /// </summary>
        Label,
        /// <summary>
        ///
        /// </summary>
        PhoneNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberSortBy value)
        {
            return value switch
            {
                PhoneNumberSortBy.Label => "label",
                PhoneNumberSortBy.PhoneNumber => "phone_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberSortBy? ToEnum(string value)
        {
            return value switch
            {
                "label" => PhoneNumberSortBy.Label,
                "phone_number" => PhoneNumberSortBy.PhoneNumber,
                _ => null,
            };
        }
    }
}