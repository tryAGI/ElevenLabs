
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility2
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility2 value)
        {
            return value switch
            {
                BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility2.Private => "private",
                BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility2.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility2? ToEnum(string value)
        {
            return value switch
            {
                "private" => BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility2.Private,
                "workspace" => BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility2.Workspace,
                _ => null,
            };
        }
    }
}