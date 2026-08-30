
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The MIME type of the encoded audio.
    /// </summary>
    public enum InlineAudioReferenceMimeType
    {
        /// <summary>
        ///
        /// </summary>
        AudioMpeg,
        /// <summary>
        ///
        /// </summary>
        AudioWav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InlineAudioReferenceMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InlineAudioReferenceMimeType value)
        {
            return value switch
            {
                InlineAudioReferenceMimeType.AudioMpeg => "audio/mpeg",
                InlineAudioReferenceMimeType.AudioWav => "audio/wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InlineAudioReferenceMimeType? ToEnum(string value)
        {
            return value switch
            {
                "audio/mpeg" => InlineAudioReferenceMimeType.AudioMpeg,
                "audio/wav" => InlineAudioReferenceMimeType.AudioWav,
                _ => null,
            };
        }
    }
}