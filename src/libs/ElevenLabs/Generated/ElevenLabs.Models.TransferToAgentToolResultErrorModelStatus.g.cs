
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: error
    /// </summary>
    public enum TransferToAgentToolResultErrorModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToAgentToolResultErrorModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToAgentToolResultErrorModelStatus value)
        {
            return value switch
            {
                TransferToAgentToolResultErrorModelStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToAgentToolResultErrorModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => TransferToAgentToolResultErrorModelStatus.Error,
                _ => null,
            };
        }
    }
}