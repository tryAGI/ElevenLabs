
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowToolLocatorSchemaOverridesDiscriminatorSource
    {
        /// <summary>
        /// 
        /// </summary>
        Constant,
        /// <summary>
        /// 
        /// </summary>
        DynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Omit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowToolLocatorSchemaOverridesDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowToolLocatorSchemaOverridesDiscriminatorSource value)
        {
            return value switch
            {
                WorkflowToolLocatorSchemaOverridesDiscriminatorSource.Constant => "constant",
                WorkflowToolLocatorSchemaOverridesDiscriminatorSource.DynamicVariable => "dynamic_variable",
                WorkflowToolLocatorSchemaOverridesDiscriminatorSource.Llm => "llm",
                WorkflowToolLocatorSchemaOverridesDiscriminatorSource.Omit => "omit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowToolLocatorSchemaOverridesDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "constant" => WorkflowToolLocatorSchemaOverridesDiscriminatorSource.Constant,
                "dynamic_variable" => WorkflowToolLocatorSchemaOverridesDiscriminatorSource.DynamicVariable,
                "llm" => WorkflowToolLocatorSchemaOverridesDiscriminatorSource.Llm,
                "omit" => WorkflowToolLocatorSchemaOverridesDiscriminatorSource.Omit,
                _ => null,
            };
        }
    }
}