
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TwilioColdBlindTransferConfigInputTransferDestinationDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Phone,
        /// <summary>
        ///
        /// </summary>
        PhoneDynamicVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioColdBlindTransferConfigInputTransferDestinationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioColdBlindTransferConfigInputTransferDestinationDiscriminatorType value)
        {
            return value switch
            {
                TwilioColdBlindTransferConfigInputTransferDestinationDiscriminatorType.Phone => "phone",
                TwilioColdBlindTransferConfigInputTransferDestinationDiscriminatorType.PhoneDynamicVariable => "phone_dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioColdBlindTransferConfigInputTransferDestinationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => TwilioColdBlindTransferConfigInputTransferDestinationDiscriminatorType.Phone,
                "phone_dynamic_variable" => TwilioColdBlindTransferConfigInputTransferDestinationDiscriminatorType.PhoneDynamicVariable,
                _ => null,
            };
        }
    }
}