
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility
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
    public static class BodyCreateMusicFinetuneV1MusicFinetunesPostVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility value)
        {
            return value switch
            {
                BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility.Private => "private",
                BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility.Private,
                "workspace" => BodyCreateMusicFinetuneV1MusicFinetunesPostVisibility.Workspace,
                _ => null,
            };
        }
    }
}