
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: music_v1
    /// </summary>
    public enum MusicModelID
    {
        /// <summary>
        /// Deprecated: Deprecated.
        /// </summary>
        MusicV1,
        /// <summary>
        ///
        /// </summary>
        MusicV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MusicModelIDExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MusicModelID value)
        {
            return value switch
            {
                MusicModelID.MusicV1 => "music_v1",
                MusicModelID.MusicV2 => "music_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MusicModelID? ToEnum(string value)
        {
            return value switch
            {
                "music_v1" => MusicModelID.MusicV1,
                "music_v2" => MusicModelID.MusicV2,
                _ => null,
            };
        }
    }
}