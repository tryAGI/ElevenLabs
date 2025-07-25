
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: transfer_to_agent_error
    /// </summary>
    public enum TransferToAgentToolResultErrorModelResultType
    {
        /// <summary>
        /// 
        /// </summary>
        TransferToAgentError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToAgentToolResultErrorModelResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToAgentToolResultErrorModelResultType value)
        {
            return value switch
            {
                TransferToAgentToolResultErrorModelResultType.TransferToAgentError => "transfer_to_agent_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToAgentToolResultErrorModelResultType? ToEnum(string value)
        {
            return value switch
            {
                "transfer_to_agent_error" => TransferToAgentToolResultErrorModelResultType.TransferToAgentError,
                _ => null,
            };
        }
    }
}