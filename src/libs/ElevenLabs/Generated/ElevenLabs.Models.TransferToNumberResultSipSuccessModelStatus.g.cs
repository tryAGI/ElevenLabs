
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum TransferToNumberResultSipSuccessModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToNumberResultSipSuccessModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToNumberResultSipSuccessModelStatus value)
        {
            return value switch
            {
                TransferToNumberResultSipSuccessModelStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToNumberResultSipSuccessModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => TransferToNumberResultSipSuccessModelStatus.Success,
                _ => null,
            };
        }
    }
}