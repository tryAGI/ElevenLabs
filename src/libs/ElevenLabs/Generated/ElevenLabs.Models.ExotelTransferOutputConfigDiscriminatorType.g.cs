
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ExotelTransferOutputConfigDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ExotelColdBlindTransfer,
        /// <summary>
        ///
        /// </summary>
        ExotelWarmTransfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExotelTransferOutputConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExotelTransferOutputConfigDiscriminatorType value)
        {
            return value switch
            {
                ExotelTransferOutputConfigDiscriminatorType.ExotelColdBlindTransfer => "exotel_cold_blind_transfer",
                ExotelTransferOutputConfigDiscriminatorType.ExotelWarmTransfer => "exotel_warm_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExotelTransferOutputConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "exotel_cold_blind_transfer" => ExotelTransferOutputConfigDiscriminatorType.ExotelColdBlindTransfer,
                "exotel_warm_transfer" => ExotelTransferOutputConfigDiscriminatorType.ExotelWarmTransfer,
                _ => null,
            };
        }
    }
}