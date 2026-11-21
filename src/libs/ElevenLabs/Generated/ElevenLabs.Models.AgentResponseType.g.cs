
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: text
    /// </summary>
    public enum AgentResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseType value)
        {
            return value switch
            {
                AgentResponseType.Text => "text",
                AgentResponseType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseType? ToEnum(string value)
        {
            return value switch
            {
                "text" => AgentResponseType.Text,
                "voice" => AgentResponseType.Voice,
                _ => null,
            };
        }
    }
}