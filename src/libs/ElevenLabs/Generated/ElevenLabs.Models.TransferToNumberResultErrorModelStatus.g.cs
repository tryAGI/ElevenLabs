
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: error
    /// </summary>
    public enum TransferToNumberResultErrorModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToNumberResultErrorModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToNumberResultErrorModelStatus value)
        {
            return value switch
            {
                TransferToNumberResultErrorModelStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToNumberResultErrorModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => TransferToNumberResultErrorModelStatus.Error,
                _ => null,
            };
        }
    }
}