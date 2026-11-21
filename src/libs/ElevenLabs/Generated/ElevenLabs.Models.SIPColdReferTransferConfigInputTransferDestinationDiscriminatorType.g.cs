
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType
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
    public static class SIPColdReferTransferConfigInputTransferDestinationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType value)
        {
            return value switch
            {
                SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType.Phone => "phone",
                SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType.PhoneDynamicVariable => "phone_dynamic_variable",
                SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType.SipUri => "sip_uri",
                SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType.SipUriDynamicVariable => "sip_uri_dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType.Phone,
                "phone_dynamic_variable" => SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType.PhoneDynamicVariable,
                "sip_uri" => SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType.SipUri,
                "sip_uri_dynamic_variable" => SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType.SipUriDynamicVariable,
                _ => null,
            };
        }
    }
}