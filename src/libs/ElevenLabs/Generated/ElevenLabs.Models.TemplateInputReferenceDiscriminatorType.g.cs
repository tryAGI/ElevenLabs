
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TemplateInputReferenceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Asset,
        /// <summary>
        ///
        /// </summary>
        Generation,
        /// <summary>
        ///
        /// </summary>
        InlineBase64,
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateInputReferenceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateInputReferenceDiscriminatorType value)
        {
            return value switch
            {
                TemplateInputReferenceDiscriminatorType.Asset => "asset",
                TemplateInputReferenceDiscriminatorType.Generation => "generation",
                TemplateInputReferenceDiscriminatorType.InlineBase64 => "inline_base64",
                TemplateInputReferenceDiscriminatorType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateInputReferenceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "asset" => TemplateInputReferenceDiscriminatorType.Asset,
                "generation" => TemplateInputReferenceDiscriminatorType.Generation,
                "inline_base64" => TemplateInputReferenceDiscriminatorType.InlineBase64,
                "voice" => TemplateInputReferenceDiscriminatorType.Voice,
                _ => null,
            };
        }
    }
}