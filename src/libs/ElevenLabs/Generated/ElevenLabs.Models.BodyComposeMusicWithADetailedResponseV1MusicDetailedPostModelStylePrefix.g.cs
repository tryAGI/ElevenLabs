
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: music
    /// </summary>
    public enum BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix
    {
        /// <summary>
        /// 
        /// </summary>
        Music,
        /// <summary>
        /// 
        /// </summary>
        Sfx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix value)
        {
            return value switch
            {
                BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix.Music => "music",
                BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix.Sfx => "sfx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix? ToEnum(string value)
        {
            return value switch
            {
                "music" => BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix.Music,
                "sfx" => BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix.Sfx,
                _ => null,
            };
        }
    }
}