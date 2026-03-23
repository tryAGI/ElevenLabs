
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
    public static class RefreshUrlDocumentRouteResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefreshUrlDocumentRouteResponseDiscriminatorType value)
        {
            return value switch
            {
                RefreshUrlDocumentRouteResponseDiscriminatorType.File => "file",
                RefreshUrlDocumentRouteResponseDiscriminatorType.Folder => "folder",
                RefreshUrlDocumentRouteResponseDiscriminatorType.Text => "text",
                RefreshUrlDocumentRouteResponseDiscriminatorType.Url => "url",
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
                "file" => RefreshUrlDocumentRouteResponseDiscriminatorType.File,
                "folder" => RefreshUrlDocumentRouteResponseDiscriminatorType.Folder,
                "text" => RefreshUrlDocumentRouteResponseDiscriminatorType.Text,
                "url" => RefreshUrlDocumentRouteResponseDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}