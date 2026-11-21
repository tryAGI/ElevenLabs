
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ExotelWarmTransferConfigOutputTransferDestinationDiscriminatorType
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
    public static class ExotelWarmTransferConfigOutputTransferDestinationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExotelWarmTransferConfigOutputTransferDestinationDiscriminatorType value)
        {
            return value switch
            {
                ExotelWarmTransferConfigOutputTransferDestinationDiscriminatorType.Phone => "phone",
                ExotelWarmTransferConfigOutputTransferDestinationDiscriminatorType.PhoneDynamicVariable => "phone_dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExotelWarmTransferConfigOutputTransferDestinationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => ExotelWarmTransferConfigOutputTransferDestinationDiscriminatorType.Phone,
                "phone_dynamic_variable" => ExotelWarmTransferConfigOutputTransferDestinationDiscriminatorType.PhoneDynamicVariable,
                _ => null,
            };
        }
    }
}