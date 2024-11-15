
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ServerEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Turn,
        /// <summary>
        /// 
        /// </summary>
        Interruption,
        /// <summary>
        /// 
        /// </summary>
        TurnAbandoned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEvent value)
        {
            return value switch
            {
                ServerEvent.Turn => "turn",
                ServerEvent.Interruption => "interruption",
                ServerEvent.TurnAbandoned => "turn_abandoned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEvent? ToEnum(string value)
        {
            return value switch
            {
                "turn" => ServerEvent.Turn,
                "interruption" => ServerEvent.Interruption,
                "turn_abandoned" => ServerEvent.TurnAbandoned,
                _ => null,
            };
        }
    }
}