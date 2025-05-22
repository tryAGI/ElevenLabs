
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The type of tool<br/>
    /// Default Value: native_mcp
    /// </summary>
    public enum NativeMCPToolConfigOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        NativeMcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NativeMCPToolConfigOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NativeMCPToolConfigOutputType value)
        {
            return value switch
            {
                NativeMCPToolConfigOutputType.NativeMcp => "native_mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NativeMCPToolConfigOutputType? ToEnum(string value)
        {
            return value switch
            {
                "native_mcp" => NativeMCPToolConfigOutputType.NativeMcp,
                _ => null,
            };
        }
    }
}