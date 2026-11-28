
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSpeechHistorySourcesVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        Flows,
        /// <summary>
        ///
        /// </summary>
        Sts,
        /// <summary>
        ///
        /// </summary>
        Tts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpeechHistorySourcesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpeechHistorySourcesVariant1Item value)
        {
            return value switch
            {
                GetSpeechHistorySourcesVariant1Item.Flows => "Flows",
                GetSpeechHistorySourcesVariant1Item.Sts => "STS",
                GetSpeechHistorySourcesVariant1Item.Tts => "TTS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpeechHistorySourcesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "Flows" => GetSpeechHistorySourcesVariant1Item.Flows,
                "STS" => GetSpeechHistorySourcesVariant1Item.Sts,
                "TTS" => GetSpeechHistorySourcesVariant1Item.Tts,
                _ => null,
            };
        }
    }
}