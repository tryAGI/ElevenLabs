
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: sip_trunk
    /// </summary>
    public enum CreateSIPTrunkPhoneNumberRequestV2Provider
    {
        /// <summary>
        /// 
        /// </summary>
        SipTrunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSIPTrunkPhoneNumberRequestV2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSIPTrunkPhoneNumberRequestV2Provider value)
        {
            return value switch
            {
                CreateSIPTrunkPhoneNumberRequestV2Provider.SipTrunk => "sip_trunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSIPTrunkPhoneNumberRequestV2Provider? ToEnum(string value)
        {
            return value switch
            {
                "sip_trunk" => CreateSIPTrunkPhoneNumberRequestV2Provider.SipTrunk,
                _ => null,
            };
        }
    }
}