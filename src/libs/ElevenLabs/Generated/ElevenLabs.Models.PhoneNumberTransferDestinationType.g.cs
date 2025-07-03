
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: phone
    /// </summary>
    public enum PhoneNumberTransferDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Phone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberTransferDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberTransferDestinationType value)
        {
            return value switch
            {
                PhoneNumberTransferDestinationType.Phone => "phone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberTransferDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => PhoneNumberTransferDestinationType.Phone,
                _ => null,
            };
        }
    }
}