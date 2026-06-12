
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The model to use for the generation.<br/>
    /// Default Value: music_v1
    /// </summary>
    public enum BodyVideoToMusicV1MusicVideoToMusicPostModelId
    {
        /// <summary>
        /// 
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
    public static class BodyVideoToMusicV1MusicVideoToMusicPostModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyVideoToMusicV1MusicVideoToMusicPostModelId value)
        {
            return value switch
            {
                BodyVideoToMusicV1MusicVideoToMusicPostModelId.MusicV1 => "music_v1",
                BodyVideoToMusicV1MusicVideoToMusicPostModelId.MusicV2 => "music_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyVideoToMusicV1MusicVideoToMusicPostModelId? ToEnum(string value)
        {
            return value switch
            {
                "music_v1" => BodyVideoToMusicV1MusicVideoToMusicPostModelId.MusicV1,
                "music_v2" => BodyVideoToMusicV1MusicVideoToMusicPostModelId.MusicV2,
                _ => null,
            };
        }
    }
}