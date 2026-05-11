
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFileDocumentRouteResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Folder,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFileDocumentRouteResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFileDocumentRouteResponseDiscriminatorType value)
        {
            return value switch
            {
                UpdateFileDocumentRouteResponseDiscriminatorType.File => "file",
                UpdateFileDocumentRouteResponseDiscriminatorType.Folder => "folder",
                UpdateFileDocumentRouteResponseDiscriminatorType.Text => "text",
                UpdateFileDocumentRouteResponseDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFileDocumentRouteResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => UpdateFileDocumentRouteResponseDiscriminatorType.File,
                "folder" => UpdateFileDocumentRouteResponseDiscriminatorType.Folder,
                "text" => UpdateFileDocumentRouteResponseDiscriminatorType.Text,
                "url" => UpdateFileDocumentRouteResponseDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}