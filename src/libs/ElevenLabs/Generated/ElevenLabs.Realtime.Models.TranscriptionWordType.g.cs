
#nullable enable

namespace ElevenLabs.Realtime
{
    /// <summary>
    /// Whether this element is a word or spacing.
    /// </summary>
    public enum TranscriptionWordType
    {
        /// <summary>
        /// 
        /// </summary>
        Word,
        /// <summary>
        /// 
        /// </summary>
        Spacing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionWordTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionWordType value)
        {
            return value switch
            {
                TranscriptionWordType.Word => "word",
                TranscriptionWordType.Spacing => "spacing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionWordType? ToEnum(string value)
        {
            return value switch
            {
                "word" => TranscriptionWordType.Word,
                "spacing" => TranscriptionWordType.Spacing,
                _ => null,
            };
        }
    }
}