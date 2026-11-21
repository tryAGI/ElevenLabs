
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum BodySpeechToTextV1SpeechToTextPostNumbersFormat
    {
        /// <summary>
        ///
        /// </summary>
        Digits,
        /// <summary>
        ///
        /// </summary>
        Words,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodySpeechToTextV1SpeechToTextPostNumbersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySpeechToTextV1SpeechToTextPostNumbersFormat value)
        {
            return value switch
            {
                BodySpeechToTextV1SpeechToTextPostNumbersFormat.Digits => "digits",
                BodySpeechToTextV1SpeechToTextPostNumbersFormat.Words => "words",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySpeechToTextV1SpeechToTextPostNumbersFormat? ToEnum(string value)
        {
            return value switch
            {
                "digits" => BodySpeechToTextV1SpeechToTextPostNumbersFormat.Digits,
                "words" => BodySpeechToTextV1SpeechToTextPostNumbersFormat.Words,
                _ => null,
            };
        }
    }
}