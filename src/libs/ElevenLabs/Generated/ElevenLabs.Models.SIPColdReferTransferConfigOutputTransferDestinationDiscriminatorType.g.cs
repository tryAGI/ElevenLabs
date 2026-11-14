
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType
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
    public static class SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType value)
        {
            return value switch
            {
                SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType.Phone => "phone",
                SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType.PhoneDynamicVariable => "phone_dynamic_variable",
                SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType.SipUri => "sip_uri",
                SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType.SipUriDynamicVariable => "sip_uri_dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType.Phone,
                "phone_dynamic_variable" => SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType.PhoneDynamicVariable,
                "sip_uri" => SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType.SipUri,
                "sip_uri_dynamic_variable" => SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType.SipUriDynamicVariable,
                _ => null,
            };
        }
    }
}