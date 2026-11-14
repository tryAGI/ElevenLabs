
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TwilioTransferOutputConfigDiscriminatorType
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
    public static class TwilioTransferOutputConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioTransferOutputConfigDiscriminatorType value)
        {
            return value switch
            {
                TwilioTransferOutputConfigDiscriminatorType.TwilioColdBlindTransfer => "twilio_cold_blind_transfer",
                TwilioTransferOutputConfigDiscriminatorType.TwilioWarmConferenceTransfer => "twilio_warm_conference_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioTransferOutputConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "twilio_cold_blind_transfer" => TwilioTransferOutputConfigDiscriminatorType.TwilioColdBlindTransfer,
                "twilio_warm_conference_transfer" => TwilioTransferOutputConfigDiscriminatorType.TwilioWarmConferenceTransfer,
                _ => null,
            };
        }
    }
}