
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAISessionConfigInputToolDiscriminatorType
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
    public static class OpenAISessionConfigInputToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAISessionConfigInputToolDiscriminatorType value)
        {
            return value switch
            {
                OpenAISessionConfigInputToolDiscriminatorType.Function => "function",
                OpenAISessionConfigInputToolDiscriminatorType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAISessionConfigInputToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function" => OpenAISessionConfigInputToolDiscriminatorType.Function,
                "mcp" => OpenAISessionConfigInputToolDiscriminatorType.Mcp,
                _ => null,
            };
        }
    }
}