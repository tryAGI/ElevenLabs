
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum TransferToAgentToolResultSuccessModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToAgentToolResultSuccessModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToAgentToolResultSuccessModelStatus value)
        {
            return value switch
            {
                TransferToAgentToolResultSuccessModelStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToAgentToolResultSuccessModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => TransferToAgentToolResultSuccessModelStatus.Success,
                _ => null,
            };
        }
    }
}