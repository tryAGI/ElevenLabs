
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClientToolConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientToolConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientToolConfigType value)
        {
            return value switch
            {
                ClientToolConfigType.Client => "client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientToolConfigType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ClientToolConfigType.Client,
                _ => null,
            };
        }
    }
}