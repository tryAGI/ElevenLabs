
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum FileContentPartSourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Base64,
        /// <summary>
        ///
        /// </summary>
        FileId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileContentPartSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileContentPartSourceDiscriminatorType value)
        {
            return value switch
            {
                FileContentPartSourceDiscriminatorType.Base64 => "base64",
                FileContentPartSourceDiscriminatorType.FileId => "file_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileContentPartSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => FileContentPartSourceDiscriminatorType.Base64,
                "file_id" => FileContentPartSourceDiscriminatorType.FileId,
                _ => null,
            };
        }
    }
}