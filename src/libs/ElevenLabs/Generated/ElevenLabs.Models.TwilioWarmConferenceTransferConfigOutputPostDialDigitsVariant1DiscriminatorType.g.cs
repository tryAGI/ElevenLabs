
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TwilioWarmConferenceTransferConfigOutputPostDialDigitsVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Dynamic,
        /// <summary>
        ///
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioWarmConferenceTransferConfigOutputPostDialDigitsVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioWarmConferenceTransferConfigOutputPostDialDigitsVariant1DiscriminatorType value)
        {
            return value switch
            {
                TwilioWarmConferenceTransferConfigOutputPostDialDigitsVariant1DiscriminatorType.Dynamic => "dynamic",
                TwilioWarmConferenceTransferConfigOutputPostDialDigitsVariant1DiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioWarmConferenceTransferConfigOutputPostDialDigitsVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => TwilioWarmConferenceTransferConfigOutputPostDialDigitsVariant1DiscriminatorType.Dynamic,
                "static" => TwilioWarmConferenceTransferConfigOutputPostDialDigitsVariant1DiscriminatorType.Static,
                _ => null,
            };
        }
    }
}