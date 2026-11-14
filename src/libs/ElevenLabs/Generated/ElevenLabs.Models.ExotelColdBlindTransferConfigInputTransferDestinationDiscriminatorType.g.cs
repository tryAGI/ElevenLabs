
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ExotelColdBlindTransferConfigInputTransferDestinationDiscriminatorType
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
    public static class ExotelColdBlindTransferConfigInputTransferDestinationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExotelColdBlindTransferConfigInputTransferDestinationDiscriminatorType value)
        {
            return value switch
            {
                ExotelColdBlindTransferConfigInputTransferDestinationDiscriminatorType.Phone => "phone",
                ExotelColdBlindTransferConfigInputTransferDestinationDiscriminatorType.PhoneDynamicVariable => "phone_dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExotelColdBlindTransferConfigInputTransferDestinationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => ExotelColdBlindTransferConfigInputTransferDestinationDiscriminatorType.Phone,
                "phone_dynamic_variable" => ExotelColdBlindTransferConfigInputTransferDestinationDiscriminatorType.PhoneDynamicVariable,
                _ => null,
            };
        }
    }
}