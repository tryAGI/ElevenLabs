
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The granularity of the timestamps in the transcription. 'word' provides word-level timestamps and 'character' provides character-level timestamps per word.<br/>
    /// Default Value: word
    /// </summary>
    public enum BodySpeechToTextStreamV1SpeechToTextStreamPostTimestampsGranularity
    {
        /// <summary>
        /// 
        /// </summary>
        Word,
        /// <summary>
        /// 
        /// </summary>
        Character,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodySpeechToTextStreamV1SpeechToTextStreamPostTimestampsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySpeechToTextStreamV1SpeechToTextStreamPostTimestampsGranularity value)
        {
            return value switch
            {
                BodySpeechToTextStreamV1SpeechToTextStreamPostTimestampsGranularity.Word => "word",
                BodySpeechToTextStreamV1SpeechToTextStreamPostTimestampsGranularity.Character => "character",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySpeechToTextStreamV1SpeechToTextStreamPostTimestampsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "word" => BodySpeechToTextStreamV1SpeechToTextStreamPostTimestampsGranularity.Word,
                "character" => BodySpeechToTextStreamV1SpeechToTextStreamPostTimestampsGranularity.Character,
                _ => null,
            };
        }
    }
}