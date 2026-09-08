
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMusicFinetuneRequestModelVisibility
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
    public static class UpdateMusicFinetuneRequestModelVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMusicFinetuneRequestModelVisibility value)
        {
            return value switch
            {
                UpdateMusicFinetuneRequestModelVisibility.Private => "private",
                UpdateMusicFinetuneRequestModelVisibility.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMusicFinetuneRequestModelVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => UpdateMusicFinetuneRequestModelVisibility.Private,
                "workspace" => UpdateMusicFinetuneRequestModelVisibility.Workspace,
                _ => null,
            };
        }
    }
}