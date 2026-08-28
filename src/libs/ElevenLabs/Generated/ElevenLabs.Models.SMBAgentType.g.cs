
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SMBAgentType
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        CustomerFacing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SMBAgentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBAgentType value)
        {
            return value switch
            {
                SMBAgentType.Assistant => "assistant",
                SMBAgentType.CustomerFacing => "customer_facing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBAgentType? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => SMBAgentType.Assistant,
                "customer_facing" => SMBAgentType.CustomerFacing,
                _ => null,
            };
        }
    }
}