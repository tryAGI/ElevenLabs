
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum MCPTransport
    {
        /// <summary>
        ///
        /// </summary>
        Sse,
        /// <summary>
        ///
        /// </summary>
        StreamableHttp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPTransport value)
        {
            return value switch
            {
                MCPTransport.Sse => "SSE",
                MCPTransport.StreamableHttp => "STREAMABLE_HTTP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPTransport? ToEnum(string value)
        {
            return value switch
            {
                "SSE" => MCPTransport.Sse,
                "STREAMABLE_HTTP" => MCPTransport.StreamableHttp,
                _ => null,
            };
        }
    }
}