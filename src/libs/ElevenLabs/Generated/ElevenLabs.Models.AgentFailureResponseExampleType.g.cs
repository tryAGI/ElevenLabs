
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentFailureResponseExampleType
    {
        /// <summary>
        /// 
        /// </summary>
        Failure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentFailureResponseExampleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentFailureResponseExampleType value)
        {
            return value switch
            {
                AgentFailureResponseExampleType.Failure => "failure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentFailureResponseExampleType? ToEnum(string value)
        {
            return value switch
            {
                "failure" => AgentFailureResponseExampleType.Failure,
                _ => null,
            };
        }
    }
}