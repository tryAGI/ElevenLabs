
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TwilioWarmConferenceTransferConfigInputPostDialDigitsVariant1DiscriminatorType
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
    public static class TwilioWarmConferenceTransferConfigInputPostDialDigitsVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioWarmConferenceTransferConfigInputPostDialDigitsVariant1DiscriminatorType value)
        {
            return value switch
            {
                TwilioWarmConferenceTransferConfigInputPostDialDigitsVariant1DiscriminatorType.Dynamic => "dynamic",
                TwilioWarmConferenceTransferConfigInputPostDialDigitsVariant1DiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioWarmConferenceTransferConfigInputPostDialDigitsVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => TwilioWarmConferenceTransferConfigInputPostDialDigitsVariant1DiscriminatorType.Dynamic,
                "static" => TwilioWarmConferenceTransferConfigInputPostDialDigitsVariant1DiscriminatorType.Static,
                _ => null,
            };
        }
    }
}