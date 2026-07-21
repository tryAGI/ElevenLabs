
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMusicFinetuneRequestModelVisibility2
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
    public static class UpdateMusicFinetuneRequestModelVisibility2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMusicFinetuneRequestModelVisibility2 value)
        {
            return value switch
            {
                UpdateMusicFinetuneRequestModelVisibility2.Private => "private",
                UpdateMusicFinetuneRequestModelVisibility2.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMusicFinetuneRequestModelVisibility2? ToEnum(string value)
        {
            return value switch
            {
                "private" => UpdateMusicFinetuneRequestModelVisibility2.Private,
                "workspace" => UpdateMusicFinetuneRequestModelVisibility2.Workspace,
                _ => null,
            };
        }
    }
}