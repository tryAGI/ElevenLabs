
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How the receptionist's greeting plays.<br/>
    /// Default Value: interruptible
    /// </summary>
    public enum FirstMessageMode
    {
        /// <summary>
        ///
        /// </summary>
        Interruptible,
        /// <summary>
        ///
        /// </summary>
        RecordingNotice,
        /// <summary>
        ///
        /// </summary>
        Uninterruptible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FirstMessageModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FirstMessageMode value)
        {
            return value switch
            {
                FirstMessageMode.Interruptible => "interruptible",
                FirstMessageMode.RecordingNotice => "recording_notice",
                FirstMessageMode.Uninterruptible => "uninterruptible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FirstMessageMode? ToEnum(string value)
        {
            return value switch
            {
                "interruptible" => FirstMessageMode.Interruptible,
                "recording_notice" => FirstMessageMode.RecordingNotice,
                "uninterruptible" => FirstMessageMode.Uninterruptible,
                _ => null,
            };
        }
    }
}