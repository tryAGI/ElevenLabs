
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Source of the generated history item<br/>
    /// Example: TTS
    /// </summary>
    public enum GetGeneratedItemsV1HistoryGetSource
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
    public static class GetGeneratedItemsV1HistoryGetSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetGeneratedItemsV1HistoryGetSource value)
        {
            return value switch
            {
                GetGeneratedItemsV1HistoryGetSource.TTS => "TTS",
                GetGeneratedItemsV1HistoryGetSource.STS => "STS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetGeneratedItemsV1HistoryGetSource? ToEnum(string value)
        {
            return value switch
            {
                "TTS" => GetGeneratedItemsV1HistoryGetSource.TTS,
                "STS" => GetGeneratedItemsV1HistoryGetSource.STS,
                _ => null,
            };
        }
    }
}