
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: audio/mpeg
    /// </summary>
    public enum VoicePreviewResponseModelMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioMpeg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicePreviewResponseModelMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicePreviewResponseModelMediaType value)
        {
            return value switch
            {
                VoicePreviewResponseModelMediaType.AudioMpeg => "audio/mpeg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicePreviewResponseModelMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio/mpeg" => VoicePreviewResponseModelMediaType.AudioMpeg,
                _ => null,
            };
        }
    }
}