
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSuccessfulResponseExampleType
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSuccessfulResponseExampleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSuccessfulResponseExampleType value)
        {
            return value switch
            {
                AgentSuccessfulResponseExampleType.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSuccessfulResponseExampleType? ToEnum(string value)
        {
            return value switch
            {
                "success" => AgentSuccessfulResponseExampleType.Success,
                _ => null,
            };
        }
    }
}