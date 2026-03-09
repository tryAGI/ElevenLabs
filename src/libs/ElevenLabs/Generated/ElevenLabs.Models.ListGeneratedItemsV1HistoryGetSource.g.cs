
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Source of the generated history item<br/>
    /// Example: TTS
    /// </summary>
    public enum ListGeneratedItemsV1HistoryGetSource
    {
        /// <summary>
        /// 
        /// </summary>
        Tts,
        /// <summary>
        /// 
        /// </summary>
        Sts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListGeneratedItemsV1HistoryGetSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListGeneratedItemsV1HistoryGetSource value)
        {
            return value switch
            {
                ListGeneratedItemsV1HistoryGetSource.Tts => "TTS",
                ListGeneratedItemsV1HistoryGetSource.Sts => "STS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListGeneratedItemsV1HistoryGetSource? ToEnum(string value)
        {
            return value switch
            {
                "TTS" => ListGeneratedItemsV1HistoryGetSource.Tts,
                "STS" => ListGeneratedItemsV1HistoryGetSource.Sts,
                _ => null,
            };
        }
    }
}