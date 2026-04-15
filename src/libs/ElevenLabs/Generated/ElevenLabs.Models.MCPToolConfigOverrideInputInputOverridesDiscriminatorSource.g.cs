
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum MCPToolConfigOverrideInputInputOverridesDiscriminatorSource
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPToolConfigOverrideInputInputOverridesDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolConfigOverrideInputInputOverridesDiscriminatorSource value)
        {
            return value switch
            {
                MCPToolConfigOverrideInputInputOverridesDiscriminatorSource.Constant => "constant",
                MCPToolConfigOverrideInputInputOverridesDiscriminatorSource.DynamicVariable => "dynamic_variable",
                MCPToolConfigOverrideInputInputOverridesDiscriminatorSource.Llm => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolConfigOverrideInputInputOverridesDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "constant" => MCPToolConfigOverrideInputInputOverridesDiscriminatorSource.Constant,
                "dynamic_variable" => MCPToolConfigOverrideInputInputOverridesDiscriminatorSource.DynamicVariable,
                "llm" => MCPToolConfigOverrideInputInputOverridesDiscriminatorSource.Llm,
                _ => null,
            };
        }
    }
}