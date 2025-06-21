
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASRProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        RealtimeScribeV1,
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
                ASRProvider.RealtimeScribeV1 => "realtime_scribe_v1",
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
                "realtime_scribe_v1" => ASRProvider.RealtimeScribeV1,
                _ => null,
            };
        }
    }
}