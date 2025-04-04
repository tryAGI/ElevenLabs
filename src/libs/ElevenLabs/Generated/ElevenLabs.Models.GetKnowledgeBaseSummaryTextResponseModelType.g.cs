
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseSummaryTextResponseModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKnowledgeBaseSummaryTextResponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseSummaryTextResponseModelType value)
        {
            return value switch
            {
                GetKnowledgeBaseSummaryTextResponseModelType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseSummaryTextResponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "text" => GetKnowledgeBaseSummaryTextResponseModelType.Text,
                _ => null,
            };
        }
    }
}