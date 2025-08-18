
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: max_iterations_exceeded
    /// </summary>
    public enum WorkflowToolMaxIterationsExceededStepModelType
    {
        /// <summary>
        /// 
        /// </summary>
        MaxIterationsExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowToolMaxIterationsExceededStepModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowToolMaxIterationsExceededStepModelType value)
        {
            return value switch
            {
                WorkflowToolMaxIterationsExceededStepModelType.MaxIterationsExceeded => "max_iterations_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowToolMaxIterationsExceededStepModelType? ToEnum(string value)
        {
            return value switch
            {
                "max_iterations_exceeded" => WorkflowToolMaxIterationsExceededStepModelType.MaxIterationsExceeded,
                _ => null,
            };
        }
    }
}