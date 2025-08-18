
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: nested_tools
    /// </summary>
    public enum WorkflowToolNestedToolsStepModelInputType
    {
        /// <summary>
        /// 
        /// </summary>
        NestedTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowToolNestedToolsStepModelInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowToolNestedToolsStepModelInputType value)
        {
            return value switch
            {
                WorkflowToolNestedToolsStepModelInputType.NestedTools => "nested_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowToolNestedToolsStepModelInputType? ToEnum(string value)
        {
            return value switch
            {
                "nested_tools" => WorkflowToolNestedToolsStepModelInputType.NestedTools,
                _ => null,
            };
        }
    }
}