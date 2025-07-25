
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: transfer_to_number_error
    /// </summary>
    public enum TransferToNumberResultErrorModelResultType
    {
        /// <summary>
        /// 
        /// </summary>
        TransferToNumberError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToNumberResultErrorModelResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToNumberResultErrorModelResultType value)
        {
            return value switch
            {
                TransferToNumberResultErrorModelResultType.TransferToNumberError => "transfer_to_number_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToNumberResultErrorModelResultType? ToEnum(string value)
        {
            return value switch
            {
                "transfer_to_number_error" => TransferToNumberResultErrorModelResultType.TransferToNumberError,
                _ => null,
            };
        }
    }
}