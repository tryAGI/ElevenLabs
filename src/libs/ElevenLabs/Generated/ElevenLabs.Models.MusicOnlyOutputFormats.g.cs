
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum MusicOnlyOutputFormats
    {
        /// <summary>
        /// 
        /// </summary>
        Mp348000128,
        /// <summary>
        /// 
        /// </summary>
        Mp348000192,
        /// <summary>
        /// 
        /// </summary>
        Mp348000240,
        /// <summary>
        /// 
        /// </summary>
        Mp348000320,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MusicOnlyOutputFormatsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MusicOnlyOutputFormats value)
        {
            return value switch
            {
                MusicOnlyOutputFormats.Mp348000128 => "mp3_48000_128",
                MusicOnlyOutputFormats.Mp348000192 => "mp3_48000_192",
                MusicOnlyOutputFormats.Mp348000240 => "mp3_48000_240",
                MusicOnlyOutputFormats.Mp348000320 => "mp3_48000_320",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MusicOnlyOutputFormats? ToEnum(string value)
        {
            return value switch
            {
                "mp3_48000_128" => MusicOnlyOutputFormats.Mp348000128,
                "mp3_48000_192" => MusicOnlyOutputFormats.Mp348000192,
                "mp3_48000_240" => MusicOnlyOutputFormats.Mp348000240,
                "mp3_48000_320" => MusicOnlyOutputFormats.Mp348000320,
                _ => null,
            };
        }
    }
}