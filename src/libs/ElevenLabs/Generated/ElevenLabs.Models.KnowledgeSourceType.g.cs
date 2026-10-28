
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Type of knowledge source.<br/>
    /// Default Value: file
    /// </summary>
    public enum KnowledgeSourceType
    {
        /// <summary>
        ///
        /// </summary>
        File,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeSourceType value)
        {
            return value switch
            {
                KnowledgeSourceType.File => "file",
                KnowledgeSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeSourceType? ToEnum(string value)
        {
            return value switch
            {
                "file" => KnowledgeSourceType.File,
                "url" => KnowledgeSourceType.Url,
                _ => null,
            };
        }
    }
}