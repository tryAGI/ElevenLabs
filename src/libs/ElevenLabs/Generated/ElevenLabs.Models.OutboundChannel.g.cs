
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum OutboundChannel
    {
        /// <summary>
        ///
        /// </summary>
        Phone,
        /// <summary>
        ///
        /// </summary>
        Whatsapp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutboundChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutboundChannel value)
        {
            return value switch
            {
                OutboundChannel.Phone => "phone",
                OutboundChannel.Whatsapp => "whatsapp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutboundChannel? ToEnum(string value)
        {
            return value switch
            {
                "phone" => OutboundChannel.Phone,
                "whatsapp" => OutboundChannel.Whatsapp,
                _ => null,
            };
        }
    }
}