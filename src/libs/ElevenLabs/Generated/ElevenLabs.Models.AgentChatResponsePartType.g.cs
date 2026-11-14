
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentChatResponsePartType
    {
        /// <summary>
        ///
        /// </summary>
        Delta,
        /// <summary>
        ///
        /// </summary>
        Start,
        /// <summary>
        ///
        /// </summary>
        Stop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentChatResponsePartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentChatResponsePartType value)
        {
            return value switch
            {
                AgentChatResponsePartType.Delta => "delta",
                AgentChatResponsePartType.Start => "start",
                AgentChatResponsePartType.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentChatResponsePartType? ToEnum(string value)
        {
            return value switch
            {
                "delta" => AgentChatResponsePartType.Delta,
                "start" => AgentChatResponsePartType.Start,
                "stop" => AgentChatResponsePartType.Stop,
                _ => null,
            };
        }
    }
}