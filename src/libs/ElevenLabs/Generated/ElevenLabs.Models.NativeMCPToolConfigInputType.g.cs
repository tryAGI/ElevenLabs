
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The type of tool<br/>
    /// Default Value: native_mcp
    /// </summary>
    public enum NativeMCPToolConfigInputType
    {
        /// <summary>
        /// 
        /// </summary>
        NativeMcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NativeMCPToolConfigInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NativeMCPToolConfigInputType value)
        {
            return value switch
            {
                NativeMCPToolConfigInputType.NativeMcp => "native_mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NativeMCPToolConfigInputType? ToEnum(string value)
        {
            return value switch
            {
                "native_mcp" => NativeMCPToolConfigInputType.NativeMcp,
                _ => null,
            };
        }
    }
}