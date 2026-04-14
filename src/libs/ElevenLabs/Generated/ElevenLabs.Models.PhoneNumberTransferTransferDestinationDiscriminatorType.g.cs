
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
        PhoneDynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        SipUri,
        /// <summary>
        /// 
        /// </summary>
        SipUriDynamicVariable,
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
                PhoneNumberTransferTransferDestinationDiscriminatorType.PhoneDynamicVariable => "phone_dynamic_variable",
                PhoneNumberTransferTransferDestinationDiscriminatorType.SipUri => "sip_uri",
                PhoneNumberTransferTransferDestinationDiscriminatorType.SipUriDynamicVariable => "sip_uri_dynamic_variable",
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
                "phone_dynamic_variable" => PhoneNumberTransferTransferDestinationDiscriminatorType.PhoneDynamicVariable,
                "sip_uri" => PhoneNumberTransferTransferDestinationDiscriminatorType.SipUri,
                "sip_uri_dynamic_variable" => PhoneNumberTransferTransferDestinationDiscriminatorType.SipUriDynamicVariable,
                _ => null,
            };
        }
    }
}