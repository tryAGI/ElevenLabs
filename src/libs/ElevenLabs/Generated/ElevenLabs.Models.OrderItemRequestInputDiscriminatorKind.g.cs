
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrderItemRequestInputDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        Dub,
        /// <summary>
        /// 
        /// </summary>
        Subtitles,
        /// <summary>
        /// 
        /// </summary>
        Transcription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrderItemRequestInputDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrderItemRequestInputDiscriminatorKind value)
        {
            return value switch
            {
                OrderItemRequestInputDiscriminatorKind.Dub => "dub",
                OrderItemRequestInputDiscriminatorKind.Subtitles => "subtitles",
                OrderItemRequestInputDiscriminatorKind.Transcription => "transcription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrderItemRequestInputDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "dub" => OrderItemRequestInputDiscriminatorKind.Dub,
                "subtitles" => OrderItemRequestInputDiscriminatorKind.Subtitles,
                "transcription" => OrderItemRequestInputDiscriminatorKind.Transcription,
                _ => null,
            };
        }
    }
}