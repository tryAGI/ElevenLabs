
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseResponseModelAccessLevel
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
    public static class GetKnowledgeBaseResponseModelAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseResponseModelAccessLevel value)
        {
            return value switch
            {
                GetKnowledgeBaseResponseModelAccessLevel.Admin => "admin",
                GetKnowledgeBaseResponseModelAccessLevel.Editor => "editor",
                GetKnowledgeBaseResponseModelAccessLevel.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseResponseModelAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetKnowledgeBaseResponseModelAccessLevel.Admin,
                "editor" => GetKnowledgeBaseResponseModelAccessLevel.Editor,
                "viewer" => GetKnowledgeBaseResponseModelAccessLevel.Viewer,
                _ => null,
            };
        }
    }
}