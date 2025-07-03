
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: sip_uri
    /// </summary>
    public enum SIPUriTransferDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        SipUri,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SIPUriTransferDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPUriTransferDestinationType value)
        {
            return value switch
            {
                SIPUriTransferDestinationType.SipUri => "sip_uri",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPUriTransferDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "sip_uri" => SIPUriTransferDestinationType.SipUri,
                _ => null,
            };
        }
    }
}