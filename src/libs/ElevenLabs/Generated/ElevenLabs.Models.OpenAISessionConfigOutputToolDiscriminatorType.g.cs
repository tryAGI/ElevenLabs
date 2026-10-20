
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAISessionConfigOutputToolDiscriminatorType
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
    public static class OpenAISessionConfigOutputToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAISessionConfigOutputToolDiscriminatorType value)
        {
            return value switch
            {
                OpenAISessionConfigOutputToolDiscriminatorType.Function => "function",
                OpenAISessionConfigOutputToolDiscriminatorType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAISessionConfigOutputToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function" => OpenAISessionConfigOutputToolDiscriminatorType.Function,
                "mcp" => OpenAISessionConfigOutputToolDiscriminatorType.Mcp,
                _ => null,
            };
        }
    }
}