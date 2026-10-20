
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// ``BURSTY`` clients stream ahead of wall time, so decisions use the audio clock.<br/>
    /// Default Value: realtime
    /// </summary>
    public enum AudioInputPacing
    {
        /// <summary>
        ///
        /// </summary>
        Bursty,
        /// <summary>
        ///
        /// </summary>
        Realtime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioInputPacingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioInputPacing value)
        {
            return value switch
            {
                AudioInputPacing.Bursty => "bursty",
                AudioInputPacing.Realtime => "realtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioInputPacing? ToEnum(string value)
        {
            return value switch
            {
                "bursty" => AudioInputPacing.Bursty,
                "realtime" => AudioInputPacing.Realtime,
                _ => null,
            };
        }
    }
}