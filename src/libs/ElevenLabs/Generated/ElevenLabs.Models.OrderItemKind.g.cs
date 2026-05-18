
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrderItemKind
    {
        /// <summary>
        /// 
        /// </summary>
        Dub,
        /// <summary>
        /// 
        /// </summary>
        Subtitles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrderItemKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrderItemKind value)
        {
            return value switch
            {
                OrderItemKind.Dub => "dub",
                OrderItemKind.Subtitles => "subtitles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrderItemKind? ToEnum(string value)
        {
            return value switch
            {
                "dub" => OrderItemKind.Dub,
                "subtitles" => OrderItemKind.Subtitles,
                _ => null,
            };
        }
    }
}