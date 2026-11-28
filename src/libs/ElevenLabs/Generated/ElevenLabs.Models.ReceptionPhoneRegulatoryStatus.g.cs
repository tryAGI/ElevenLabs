
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Regulatory standing of a number in a country that requires paperwork.<br/>
    /// Null for numbers that need no paperwork, such as US and Canadian numbers.
    /// </summary>
    public enum ReceptionPhoneRegulatoryStatus
    {
        /// <summary>
        ///
        /// </summary>
        Approved,
        /// <summary>
        ///
        /// </summary>
        Held,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReceptionPhoneRegulatoryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionPhoneRegulatoryStatus value)
        {
            return value switch
            {
                ReceptionPhoneRegulatoryStatus.Approved => "approved",
                ReceptionPhoneRegulatoryStatus.Held => "held",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionPhoneRegulatoryStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => ReceptionPhoneRegulatoryStatus.Approved,
                "held" => ReceptionPhoneRegulatoryStatus.Held,
                _ => null,
            };
        }
    }
}