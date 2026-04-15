
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource
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
    public static class MCPToolConfigOverrideOutputInputOverridesDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource value)
        {
            return value switch
            {
                MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource.Constant => "constant",
                MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource.DynamicVariable => "dynamic_variable",
                MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource.Llm => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "constant" => MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource.Constant,
                "dynamic_variable" => MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource.DynamicVariable,
                "llm" => MCPToolConfigOverrideOutputInputOverridesDiscriminatorSource.Llm,
                _ => null,
            };
        }
    }
}