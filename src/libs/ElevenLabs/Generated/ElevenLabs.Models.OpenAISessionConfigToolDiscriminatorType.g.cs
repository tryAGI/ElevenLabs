
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAISessionConfigToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAISessionConfigToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAISessionConfigToolDiscriminatorType value)
        {
            return value switch
            {
                OpenAISessionConfigToolDiscriminatorType.Function => "function",
                OpenAISessionConfigToolDiscriminatorType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAISessionConfigToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function" => OpenAISessionConfigToolDiscriminatorType.Function,
                "mcp" => OpenAISessionConfigToolDiscriminatorType.Mcp,
                _ => null,
            };
        }
    }
}