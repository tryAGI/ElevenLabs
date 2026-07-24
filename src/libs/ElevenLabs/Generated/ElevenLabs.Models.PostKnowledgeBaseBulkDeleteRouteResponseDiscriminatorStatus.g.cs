
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus value)
        {
            return value switch
            {
                PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus.Failure => "failure",
                PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus.Failure,
                "success" => PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus.Success,
                _ => null,
            };
        }
    }
}