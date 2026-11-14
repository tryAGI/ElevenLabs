
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TwilioTransferInputConfigDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        TwilioColdBlindTransfer,
        /// <summary>
        ///
        /// </summary>
        TwilioWarmConferenceTransfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioTransferInputConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioTransferInputConfigDiscriminatorType value)
        {
            return value switch
            {
                TwilioTransferInputConfigDiscriminatorType.TwilioColdBlindTransfer => "twilio_cold_blind_transfer",
                TwilioTransferInputConfigDiscriminatorType.TwilioWarmConferenceTransfer => "twilio_warm_conference_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioTransferInputConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "twilio_cold_blind_transfer" => TwilioTransferInputConfigDiscriminatorType.TwilioColdBlindTransfer,
                "twilio_warm_conference_transfer" => TwilioTransferInputConfigDiscriminatorType.TwilioWarmConferenceTransfer,
                _ => null,
            };
        }
    }
}