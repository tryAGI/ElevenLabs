
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SIPTransferOutputConfigDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        SipColdConferenceTransfer,
        /// <summary>
        ///
        /// </summary>
        SipColdReferTransfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SIPTransferOutputConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPTransferOutputConfigDiscriminatorType value)
        {
            return value switch
            {
                SIPTransferOutputConfigDiscriminatorType.SipColdConferenceTransfer => "sip_cold_conference_transfer",
                SIPTransferOutputConfigDiscriminatorType.SipColdReferTransfer => "sip_cold_refer_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPTransferOutputConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "sip_cold_conference_transfer" => SIPTransferOutputConfigDiscriminatorType.SipColdConferenceTransfer,
                "sip_cold_refer_transfer" => SIPTransferOutputConfigDiscriminatorType.SipColdReferTransfer,
                _ => null,
            };
        }
    }
}