
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ExotelColdBlindTransferConfigOutputTransferDestinationDiscriminatorType
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
    public static class ExotelColdBlindTransferConfigOutputTransferDestinationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExotelColdBlindTransferConfigOutputTransferDestinationDiscriminatorType value)
        {
            return value switch
            {
                ExotelColdBlindTransferConfigOutputTransferDestinationDiscriminatorType.Phone => "phone",
                ExotelColdBlindTransferConfigOutputTransferDestinationDiscriminatorType.PhoneDynamicVariable => "phone_dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExotelColdBlindTransferConfigOutputTransferDestinationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => ExotelColdBlindTransferConfigOutputTransferDestinationDiscriminatorType.Phone,
                "phone_dynamic_variable" => ExotelColdBlindTransferConfigOutputTransferDestinationDiscriminatorType.PhoneDynamicVariable,
                _ => null,
            };
        }
    }
}