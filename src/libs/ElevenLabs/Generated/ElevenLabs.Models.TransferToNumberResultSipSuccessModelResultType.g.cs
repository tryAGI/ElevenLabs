
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: transfer_to_number_sip_success
    /// </summary>
    public enum TransferToNumberResultSipSuccessModelResultType
    {
        /// <summary>
        /// 
        /// </summary>
        TransferToNumberSipSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToNumberResultSipSuccessModelResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToNumberResultSipSuccessModelResultType value)
        {
            return value switch
            {
                TransferToNumberResultSipSuccessModelResultType.TransferToNumberSipSuccess => "transfer_to_number_sip_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToNumberResultSipSuccessModelResultType? ToEnum(string value)
        {
            return value switch
            {
                "transfer_to_number_sip_success" => TransferToNumberResultSipSuccessModelResultType.TransferToNumberSipSuccess,
                _ => null,
            };
        }
    }
}