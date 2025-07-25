
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: transfer_to_number_twilio_success
    /// </summary>
    public enum TransferToNumberResultTwilioSuccessModelResultType
    {
        /// <summary>
        /// 
        /// </summary>
        TransferToNumberTwilioSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToNumberResultTwilioSuccessModelResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToNumberResultTwilioSuccessModelResultType value)
        {
            return value switch
            {
                TransferToNumberResultTwilioSuccessModelResultType.TransferToNumberTwilioSuccess => "transfer_to_number_twilio_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToNumberResultTwilioSuccessModelResultType? ToEnum(string value)
        {
            return value switch
            {
                "transfer_to_number_twilio_success" => TransferToNumberResultTwilioSuccessModelResultType.TransferToNumberTwilioSuccess,
                _ => null,
            };
        }
    }
}