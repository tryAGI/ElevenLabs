
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The model to use for the generation.<br/>
    /// Default Value: music_v1
    /// </summary>
    public enum BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPostModelId
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
    public static class BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPostModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPostModelId value)
        {
            return value switch
            {
                BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPostModelId.MusicV1 => "music_v1",
                BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPostModelId.MusicV2 => "music_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPostModelId? ToEnum(string value)
        {
            return value switch
            {
                "music_v1" => BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPostModelId.MusicV1,
                "music_v2" => BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPostModelId.MusicV2,
                _ => null,
            };
        }
    }
}