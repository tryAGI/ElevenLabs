
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ExotelTransferInputConfigDiscriminatorType
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
    public static class ExotelTransferInputConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExotelTransferInputConfigDiscriminatorType value)
        {
            return value switch
            {
                ExotelTransferInputConfigDiscriminatorType.ExotelColdBlindTransfer => "exotel_cold_blind_transfer",
                ExotelTransferInputConfigDiscriminatorType.ExotelWarmTransfer => "exotel_warm_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExotelTransferInputConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "exotel_cold_blind_transfer" => ExotelTransferInputConfigDiscriminatorType.ExotelColdBlindTransfer,
                "exotel_warm_transfer" => ExotelTransferInputConfigDiscriminatorType.ExotelWarmTransfer,
                _ => null,
            };
        }
    }
}