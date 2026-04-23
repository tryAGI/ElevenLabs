
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum PreToolSpeechMode
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Force,
        /// <summary>
        /// 
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreToolSpeechModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreToolSpeechMode value)
        {
            return value switch
            {
                PreToolSpeechMode.Auto => "auto",
                PreToolSpeechMode.Force => "force",
                PreToolSpeechMode.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreToolSpeechMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PreToolSpeechMode.Auto,
                "force" => PreToolSpeechMode.Force,
                "off" => PreToolSpeechMode.Off,
                _ => null,
            };
        }
    }
}