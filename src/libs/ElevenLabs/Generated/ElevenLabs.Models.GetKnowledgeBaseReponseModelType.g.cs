
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseReponseModelType
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
    public static class GetKnowledgeBaseReponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseReponseModelType value)
        {
            return value switch
            {
                GetKnowledgeBaseReponseModelType.File => "file",
                GetKnowledgeBaseReponseModelType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseReponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "file" => GetKnowledgeBaseReponseModelType.File,
                "url" => GetKnowledgeBaseReponseModelType.Url,
                _ => null,
            };
        }
    }
}