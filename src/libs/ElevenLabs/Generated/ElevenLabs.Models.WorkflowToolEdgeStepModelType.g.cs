
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: edge
    /// </summary>
    public enum WorkflowToolEdgeStepModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Edge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowToolEdgeStepModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowToolEdgeStepModelType value)
        {
            return value switch
            {
                WorkflowToolEdgeStepModelType.Edge => "edge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowToolEdgeStepModelType? ToEnum(string value)
        {
            return value switch
            {
                "edge" => WorkflowToolEdgeStepModelType.Edge,
                _ => null,
            };
        }
    }
}