
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The MIME type of the encoded image.
    /// </summary>
    public enum InlineImageReferenceMimeType
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InlineImageReferenceMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InlineImageReferenceMimeType value)
        {
            return value switch
            {
                InlineImageReferenceMimeType.ImageHeic => "image/heic",
                InlineImageReferenceMimeType.ImageHeif => "image/heif",
                InlineImageReferenceMimeType.ImageJpeg => "image/jpeg",
                InlineImageReferenceMimeType.ImagePng => "image/png",
                InlineImageReferenceMimeType.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InlineImageReferenceMimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/heic" => InlineImageReferenceMimeType.ImageHeic,
                "image/heif" => InlineImageReferenceMimeType.ImageHeif,
                "image/jpeg" => InlineImageReferenceMimeType.ImageJpeg,
                "image/png" => InlineImageReferenceMimeType.ImagePng,
                "image/webp" => InlineImageReferenceMimeType.ImageWebp,
                _ => null,
            };
        }
    }
}