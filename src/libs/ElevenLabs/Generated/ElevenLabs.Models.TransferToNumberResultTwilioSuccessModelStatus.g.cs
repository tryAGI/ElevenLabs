
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum TransferToNumberResultTwilioSuccessModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToNumberResultTwilioSuccessModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToNumberResultTwilioSuccessModelStatus value)
        {
            return value switch
            {
                TransferToNumberResultTwilioSuccessModelStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToNumberResultTwilioSuccessModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => TransferToNumberResultTwilioSuccessModelStatus.Success,
                _ => null,
            };
        }
    }
}