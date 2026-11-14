
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TwilioColdBlindTransferConfigOutputPostDialDigitsVariant1DiscriminatorType
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
    public static class TwilioColdBlindTransferConfigOutputPostDialDigitsVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioColdBlindTransferConfigOutputPostDialDigitsVariant1DiscriminatorType value)
        {
            return value switch
            {
                TwilioColdBlindTransferConfigOutputPostDialDigitsVariant1DiscriminatorType.Dynamic => "dynamic",
                TwilioColdBlindTransferConfigOutputPostDialDigitsVariant1DiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioColdBlindTransferConfigOutputPostDialDigitsVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => TwilioColdBlindTransferConfigOutputPostDialDigitsVariant1DiscriminatorType.Dynamic,
                "static" => TwilioColdBlindTransferConfigOutputPostDialDigitsVariant1DiscriminatorType.Static,
                _ => null,
            };
        }
    }
}