
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum RefreshUrlDocumentRouteResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Folder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RefreshUrlDocumentRouteResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefreshUrlDocumentRouteResponseDiscriminatorType value)
        {
            return value switch
            {
                RefreshUrlDocumentRouteResponseDiscriminatorType.Url => "url",
                RefreshUrlDocumentRouteResponseDiscriminatorType.File => "file",
                RefreshUrlDocumentRouteResponseDiscriminatorType.Text => "text",
                RefreshUrlDocumentRouteResponseDiscriminatorType.Folder => "folder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefreshUrlDocumentRouteResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "url" => RefreshUrlDocumentRouteResponseDiscriminatorType.Url,
                "file" => RefreshUrlDocumentRouteResponseDiscriminatorType.File,
                "text" => RefreshUrlDocumentRouteResponseDiscriminatorType.Text,
                "folder" => RefreshUrlDocumentRouteResponseDiscriminatorType.Folder,
                _ => null,
            };
        }
    }
}