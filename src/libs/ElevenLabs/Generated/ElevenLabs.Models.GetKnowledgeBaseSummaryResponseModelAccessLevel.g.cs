
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseSummaryResponseModelAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Editor,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKnowledgeBaseSummaryResponseModelAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseSummaryResponseModelAccessLevel value)
        {
            return value switch
            {
                GetKnowledgeBaseSummaryResponseModelAccessLevel.Admin => "admin",
                GetKnowledgeBaseSummaryResponseModelAccessLevel.Editor => "editor",
                GetKnowledgeBaseSummaryResponseModelAccessLevel.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseSummaryResponseModelAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetKnowledgeBaseSummaryResponseModelAccessLevel.Admin,
                "editor" => GetKnowledgeBaseSummaryResponseModelAccessLevel.Editor,
                "viewer" => GetKnowledgeBaseSummaryResponseModelAccessLevel.Viewer,
                _ => null,
            };
        }
    }
}