
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The source type of the project.
    /// </summary>
    public enum ProjectResponseModelSourceType
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
    public static class ProjectResponseModelSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectResponseModelSourceType value)
        {
            return value switch
            {
                ProjectResponseModelSourceType.Blank => "blank",
                ProjectResponseModelSourceType.Book => "book",
                ProjectResponseModelSourceType.Article => "article",
                ProjectResponseModelSourceType.Genfm => "genfm",
                ProjectResponseModelSourceType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectResponseModelSourceType? ToEnum(string value)
        {
            return value switch
            {
                "blank" => ProjectResponseModelSourceType.Blank,
                "book" => ProjectResponseModelSourceType.Book,
                "article" => ProjectResponseModelSourceType.Article,
                "genfm" => ProjectResponseModelSourceType.Genfm,
                "video" => ProjectResponseModelSourceType.Video,
                _ => null,
            };
        }
    }
}