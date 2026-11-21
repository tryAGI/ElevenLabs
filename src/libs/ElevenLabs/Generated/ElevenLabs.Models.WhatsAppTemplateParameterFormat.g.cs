
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: POSITIONAL
    /// </summary>
    public enum WhatsAppTemplateParameterFormat
    {
        /// <summary>
        ///
        /// </summary>
        Named,
        /// <summary>
        ///
        /// </summary>
        Positional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WhatsAppTemplateParameterFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WhatsAppTemplateParameterFormat value)
        {
            return value switch
            {
                WhatsAppTemplateParameterFormat.Named => "NAMED",
                WhatsAppTemplateParameterFormat.Positional => "POSITIONAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WhatsAppTemplateParameterFormat? ToEnum(string value)
        {
            return value switch
            {
                "NAMED" => WhatsAppTemplateParameterFormat.Named,
                "POSITIONAL" => WhatsAppTemplateParameterFormat.Positional,
                _ => null,
            };
        }
    }
}