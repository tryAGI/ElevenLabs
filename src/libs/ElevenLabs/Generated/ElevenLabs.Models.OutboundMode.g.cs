
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum OutboundMode
    {
        /// <summary>
        ///
        /// </summary>
        Message,
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutboundModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutboundMode value)
        {
            return value switch
            {
                OutboundMode.Message => "message",
                OutboundMode.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutboundMode? ToEnum(string value)
        {
            return value switch
            {
                "message" => OutboundMode.Message,
                "voice" => OutboundMode.Voice,
                _ => null,
            };
        }
    }
}