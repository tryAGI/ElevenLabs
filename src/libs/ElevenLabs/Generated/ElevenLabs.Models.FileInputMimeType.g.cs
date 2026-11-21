
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum FileInputMimeType
    {
        /// <summary>
        ///
        /// </summary>
        ApplicationPdf,
        /// <summary>
        ///
        /// </summary>
        ImageGif,
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
        TextPlain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileInputMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileInputMimeType value)
        {
            return value switch
            {
                FileInputMimeType.ApplicationPdf => "application/pdf",
                FileInputMimeType.ImageGif => "image/gif",
                FileInputMimeType.ImageJpeg => "image/jpeg",
                FileInputMimeType.ImagePng => "image/png",
                FileInputMimeType.ImageWebp => "image/webp",
                FileInputMimeType.TextPlain => "text/plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileInputMimeType? ToEnum(string value)
        {
            return value switch
            {
                "application/pdf" => FileInputMimeType.ApplicationPdf,
                "image/gif" => FileInputMimeType.ImageGif,
                "image/jpeg" => FileInputMimeType.ImageJpeg,
                "image/png" => FileInputMimeType.ImagePng,
                "image/webp" => FileInputMimeType.ImageWebp,
                "text/plain" => FileInputMimeType.TextPlain,
                _ => null,
            };
        }
    }
}