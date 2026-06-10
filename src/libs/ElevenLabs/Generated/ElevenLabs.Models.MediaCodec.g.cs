
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum MediaCodec
    {
        /// <summary>
        /// 
        /// </summary>
        G7228000,
        /// <summary>
        /// 
        /// </summary>
        Pcma8000,
        /// <summary>
        /// 
        /// </summary>
        Pcmu8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MediaCodecExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MediaCodec value)
        {
            return value switch
            {
                MediaCodec.G7228000 => "G722/8000",
                MediaCodec.Pcma8000 => "PCMA/8000",
                MediaCodec.Pcmu8000 => "PCMU/8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MediaCodec? ToEnum(string value)
        {
            return value switch
            {
                "G722/8000" => MediaCodec.G7228000,
                "PCMA/8000" => MediaCodec.Pcma8000,
                "PCMU/8000" => MediaCodec.Pcmu8000,
                _ => null,
            };
        }
    }
}