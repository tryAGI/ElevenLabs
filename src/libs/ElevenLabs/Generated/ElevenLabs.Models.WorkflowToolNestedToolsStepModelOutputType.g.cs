
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: nested_tools
    /// </summary>
    public enum WorkflowToolNestedToolsStepModelOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        NestedTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowToolNestedToolsStepModelOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowToolNestedToolsStepModelOutputType value)
        {
            return value switch
            {
                WorkflowToolNestedToolsStepModelOutputType.NestedTools => "nested_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowToolNestedToolsStepModelOutputType? ToEnum(string value)
        {
            return value switch
            {
                "nested_tools" => WorkflowToolNestedToolsStepModelOutputType.NestedTools,
                _ => null,
            };
        }
    }
}