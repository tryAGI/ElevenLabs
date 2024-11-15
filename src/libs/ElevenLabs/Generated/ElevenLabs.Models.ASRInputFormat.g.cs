
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ASRInputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Pcm16000,
        /// <summary>
        /// 
        /// </summary>
        Pcm22050,
        /// <summary>
        /// 
        /// </summary>
        Pcm24000,
        /// <summary>
        /// 
        /// </summary>
        Pcm44100,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ASRInputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASRInputFormat value)
        {
            return value switch
            {
                ASRInputFormat.Pcm16000 => "pcm_16000",
                ASRInputFormat.Pcm22050 => "pcm_22050",
                ASRInputFormat.Pcm24000 => "pcm_24000",
                ASRInputFormat.Pcm44100 => "pcm_44100",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASRInputFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm_16000" => ASRInputFormat.Pcm16000,
                "pcm_22050" => ASRInputFormat.Pcm22050,
                "pcm_24000" => ASRInputFormat.Pcm24000,
                "pcm_44100" => ASRInputFormat.Pcm44100,
                _ => null,
            };
        }
    }
}