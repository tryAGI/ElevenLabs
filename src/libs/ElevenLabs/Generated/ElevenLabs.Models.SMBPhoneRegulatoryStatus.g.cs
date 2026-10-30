
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Regulatory standing of a number in a country that requires paperwork.<br/>
    /// Absent (``None``) on numbers from countries with no requirements, which is<br/>
    /// every pooled US/Canada number — those are usable the moment they are bought.
    /// </summary>
    public enum SMBPhoneRegulatoryStatus
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
    public static class SMBPhoneRegulatoryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBPhoneRegulatoryStatus value)
        {
            return value switch
            {
                SMBPhoneRegulatoryStatus.Approved => "approved",
                SMBPhoneRegulatoryStatus.Held => "held",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBPhoneRegulatoryStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => SMBPhoneRegulatoryStatus.Approved,
                "held" => SMBPhoneRegulatoryStatus.Held,
                _ => null,
            };
        }
    }
}