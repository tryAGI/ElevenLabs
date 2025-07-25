
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: transfer_to_agent_success
    /// </summary>
    public enum TransferToAgentToolResultSuccessModelResultType
    {
        /// <summary>
        /// 
        /// </summary>
        TransferToAgentSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToAgentToolResultSuccessModelResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToAgentToolResultSuccessModelResultType value)
        {
            return value switch
            {
                TransferToAgentToolResultSuccessModelResultType.TransferToAgentSuccess => "transfer_to_agent_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToAgentToolResultSuccessModelResultType? ToEnum(string value)
        {
            return value switch
            {
                "transfer_to_agent_success" => TransferToAgentToolResultSuccessModelResultType.TransferToAgentSuccess,
                _ => null,
            };
        }
    }
}