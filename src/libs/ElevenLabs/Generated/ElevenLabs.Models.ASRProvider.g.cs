
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: scribe_v3_live
    /// </summary>
    public enum ASRProvider
    {
        /// <summary>
        /// Deprecated: Use scribe_realtime instead.
        /// </summary>
        Elevenlabs,
        /// <summary>
        ///
        /// </summary>
        ScribeRealtime,
        /// <summary>
        ///
        /// </summary>
        ScribeV2Turbo,
        /// <summary>
        ///
        /// </summary>
        ScribeV3Live,
        /// <summary>
        ///
        /// </summary>
        ScribeV3LiveMedical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ASRProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASRProvider value)
        {
            return value switch
            {
                ASRProvider.Elevenlabs => "elevenlabs",
                ASRProvider.ScribeRealtime => "scribe_realtime",
                ASRProvider.ScribeV2Turbo => "scribe_v2_turbo",
                ASRProvider.ScribeV3Live => "scribe_v3_live",
                ASRProvider.ScribeV3LiveMedical => "scribe_v3_live_medical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASRProvider? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => ASRProvider.Elevenlabs,
                "scribe_realtime" => ASRProvider.ScribeRealtime,
                "scribe_v2_turbo" => ASRProvider.ScribeV2Turbo,
                "scribe_v3_live" => ASRProvider.ScribeV3Live,
                "scribe_v3_live_medical" => ASRProvider.ScribeV3LiveMedical,
                _ => null,
            };
        }
    }
}