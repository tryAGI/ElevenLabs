
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseResponseModelType
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
    public static class GetKnowledgeBaseResponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseResponseModelType value)
        {
            return value switch
            {
                GetKnowledgeBaseResponseModelType.File => "file",
                GetKnowledgeBaseResponseModelType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseResponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "file" => GetKnowledgeBaseResponseModelType.File,
                "url" => GetKnowledgeBaseResponseModelType.Url,
                _ => null,
            };
        }
    }
}