
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SIPTransferInputConfigDiscriminatorType
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
    public static class SIPTransferInputConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPTransferInputConfigDiscriminatorType value)
        {
            return value switch
            {
                SIPTransferInputConfigDiscriminatorType.SipColdConferenceTransfer => "sip_cold_conference_transfer",
                SIPTransferInputConfigDiscriminatorType.SipColdReferTransfer => "sip_cold_refer_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPTransferInputConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "sip_cold_conference_transfer" => SIPTransferInputConfigDiscriminatorType.SipColdConferenceTransfer,
                "sip_cold_refer_transfer" => SIPTransferInputConfigDiscriminatorType.SipColdReferTransfer,
                _ => null,
            };
        }
    }
}