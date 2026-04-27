
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeminiLLMParametersPromptPartDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageReference,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        TextReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeminiLLMParametersPromptPartDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeminiLLMParametersPromptPartDiscriminatorType value)
        {
            return value switch
            {
                GeminiLLMParametersPromptPartDiscriminatorType.ImageReference => "image_reference",
                GeminiLLMParametersPromptPartDiscriminatorType.Text => "text",
                GeminiLLMParametersPromptPartDiscriminatorType.TextReference => "text_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeminiLLMParametersPromptPartDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_reference" => GeminiLLMParametersPromptPartDiscriminatorType.ImageReference,
                "text" => GeminiLLMParametersPromptPartDiscriminatorType.Text,
                "text_reference" => GeminiLLMParametersPromptPartDiscriminatorType.TextReference,
                _ => null,
            };
        }
    }
}