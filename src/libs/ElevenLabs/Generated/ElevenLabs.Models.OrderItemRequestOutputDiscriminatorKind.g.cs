
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrderItemRequestOutputDiscriminatorKind
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
    public static class OrderItemRequestOutputDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrderItemRequestOutputDiscriminatorKind value)
        {
            return value switch
            {
                OrderItemRequestOutputDiscriminatorKind.Dub => "dub",
                OrderItemRequestOutputDiscriminatorKind.Subtitles => "subtitles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrderItemRequestOutputDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "dub" => OrderItemRequestOutputDiscriminatorKind.Dub,
                "subtitles" => OrderItemRequestOutputDiscriminatorKind.Subtitles,
                _ => null,
            };
        }
    }
}