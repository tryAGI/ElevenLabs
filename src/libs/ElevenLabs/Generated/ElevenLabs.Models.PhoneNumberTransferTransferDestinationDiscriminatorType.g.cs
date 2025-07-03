
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoneNumberTransferTransferDestinationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Phone,
        /// <summary>
        /// 
        /// </summary>
        SipUri,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberTransferTransferDestinationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberTransferTransferDestinationDiscriminatorType value)
        {
            return value switch
            {
                PhoneNumberTransferTransferDestinationDiscriminatorType.Phone => "phone",
                PhoneNumberTransferTransferDestinationDiscriminatorType.SipUri => "sip_uri",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberTransferTransferDestinationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => PhoneNumberTransferTransferDestinationDiscriminatorType.Phone,
                "sip_uri" => PhoneNumberTransferTransferDestinationDiscriminatorType.SipUri,
                _ => null,
            };
        }
    }
}