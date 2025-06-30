
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The source type of the project.
    /// </summary>
    public enum ProjectExtendedResponseModelSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Blank,
        /// <summary>
        /// 
        /// </summary>
        Book,
        /// <summary>
        /// 
        /// </summary>
        Article,
        /// <summary>
        /// 
        /// </summary>
        Genfm,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectExtendedResponseModelSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelSourceType value)
        {
            return value switch
            {
                ProjectExtendedResponseModelSourceType.Blank => "blank",
                ProjectExtendedResponseModelSourceType.Book => "book",
                ProjectExtendedResponseModelSourceType.Article => "article",
                ProjectExtendedResponseModelSourceType.Genfm => "genfm",
                ProjectExtendedResponseModelSourceType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelSourceType? ToEnum(string value)
        {
            return value switch
            {
                "blank" => ProjectExtendedResponseModelSourceType.Blank,
                "book" => ProjectExtendedResponseModelSourceType.Book,
                "article" => ProjectExtendedResponseModelSourceType.Article,
                "genfm" => ProjectExtendedResponseModelSourceType.Genfm,
                "video" => ProjectExtendedResponseModelSourceType.Video,
                _ => null,
            };
        }
    }
}