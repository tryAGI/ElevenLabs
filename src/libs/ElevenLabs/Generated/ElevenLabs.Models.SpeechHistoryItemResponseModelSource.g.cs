
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechHistoryItemResponseModelSource
    {
        /// <summary>
        /// 
        /// </summary>
        TTS,
        /// <summary>
        /// 
        /// </summary>
        STS,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechHistoryItemResponseModelSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechHistoryItemResponseModelSource value)
        {
            return value switch
            {
                SpeechHistoryItemResponseModelSource.TTS => "TTS",
                SpeechHistoryItemResponseModelSource.STS => "STS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechHistoryItemResponseModelSource? ToEnum(string value)
        {
            return value switch
            {
                "TTS" => SpeechHistoryItemResponseModelSource.TTS,
                "STS" => SpeechHistoryItemResponseModelSource.STS,
                _ => null,
            };
        }
    }
}