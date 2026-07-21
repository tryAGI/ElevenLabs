
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The model to create a finetune for.<br/>
    /// Default Value: music_v1
    /// </summary>
    public enum BodyCreateMusicFinetuneV1MusicFinetunesPostModelId
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
    public static class BodyCreateMusicFinetuneV1MusicFinetunesPostModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateMusicFinetuneV1MusicFinetunesPostModelId value)
        {
            return value switch
            {
                BodyCreateMusicFinetuneV1MusicFinetunesPostModelId.MusicV1 => "music_v1",
                BodyCreateMusicFinetuneV1MusicFinetunesPostModelId.MusicV2 => "music_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateMusicFinetuneV1MusicFinetunesPostModelId? ToEnum(string value)
        {
            return value switch
            {
                "music_v1" => BodyCreateMusicFinetuneV1MusicFinetunesPostModelId.MusicV1,
                "music_v2" => BodyCreateMusicFinetuneV1MusicFinetunesPostModelId.MusicV2,
                _ => null,
            };
        }
    }
}