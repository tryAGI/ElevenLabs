
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The MIME type of the encoded media.
    /// </summary>
    public enum InlineBase64ReferenceMimeType
    {
        /// <summary>
        ///
        /// </summary>
        AudioMpeg,
        /// <summary>
        ///
        /// </summary>
        AudioWav,
        /// <summary>
        ///
        /// </summary>
        ImageHeic,
        /// <summary>
        ///
        /// </summary>
        ImageHeif,
        /// <summary>
        ///
        /// </summary>
        ImageJpeg,
        /// <summary>
        ///
        /// </summary>
        ImagePng,
        /// <summary>
        ///
        /// </summary>
        ImageWebp,
        /// <summary>
        ///
        /// </summary>
        VideoMp4,
        /// <summary>
        ///
        /// </summary>
        VideoQuicktime,
        /// <summary>
        ///
        /// </summary>
        VideoWebm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InlineBase64ReferenceMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InlineBase64ReferenceMimeType value)
        {
            return value switch
            {
                InlineBase64ReferenceMimeType.AudioMpeg => "audio/mpeg",
                InlineBase64ReferenceMimeType.AudioWav => "audio/wav",
                InlineBase64ReferenceMimeType.ImageHeic => "image/heic",
                InlineBase64ReferenceMimeType.ImageHeif => "image/heif",
                InlineBase64ReferenceMimeType.ImageJpeg => "image/jpeg",
                InlineBase64ReferenceMimeType.ImagePng => "image/png",
                InlineBase64ReferenceMimeType.ImageWebp => "image/webp",
                InlineBase64ReferenceMimeType.VideoMp4 => "video/mp4",
                InlineBase64ReferenceMimeType.VideoQuicktime => "video/quicktime",
                InlineBase64ReferenceMimeType.VideoWebm => "video/webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InlineBase64ReferenceMimeType? ToEnum(string value)
        {
            return value switch
            {
                "audio/mpeg" => InlineBase64ReferenceMimeType.AudioMpeg,
                "audio/wav" => InlineBase64ReferenceMimeType.AudioWav,
                "image/heic" => InlineBase64ReferenceMimeType.ImageHeic,
                "image/heif" => InlineBase64ReferenceMimeType.ImageHeif,
                "image/jpeg" => InlineBase64ReferenceMimeType.ImageJpeg,
                "image/png" => InlineBase64ReferenceMimeType.ImagePng,
                "image/webp" => InlineBase64ReferenceMimeType.ImageWebp,
                "video/mp4" => InlineBase64ReferenceMimeType.VideoMp4,
                "video/quicktime" => InlineBase64ReferenceMimeType.VideoQuicktime,
                "video/webm" => InlineBase64ReferenceMimeType.VideoWebm,
                _ => null,
            };
        }
    }
}