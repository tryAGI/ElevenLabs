
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TemplateOutputDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Array,
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Integer,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        Object,
        /// <summary>
        ///
        /// </summary>
        String,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateOutputDiscriminatorType value)
        {
            return value switch
            {
                TemplateOutputDiscriminatorType.Array => "array",
                TemplateOutputDiscriminatorType.Audio => "audio",
                TemplateOutputDiscriminatorType.Boolean => "boolean",
                TemplateOutputDiscriminatorType.Image => "image",
                TemplateOutputDiscriminatorType.Integer => "integer",
                TemplateOutputDiscriminatorType.Number => "number",
                TemplateOutputDiscriminatorType.Object => "object",
                TemplateOutputDiscriminatorType.String => "string",
                TemplateOutputDiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "array" => TemplateOutputDiscriminatorType.Array,
                "audio" => TemplateOutputDiscriminatorType.Audio,
                "boolean" => TemplateOutputDiscriminatorType.Boolean,
                "image" => TemplateOutputDiscriminatorType.Image,
                "integer" => TemplateOutputDiscriminatorType.Integer,
                "number" => TemplateOutputDiscriminatorType.Number,
                "object" => TemplateOutputDiscriminatorType.Object,
                "string" => TemplateOutputDiscriminatorType.String,
                "video" => TemplateOutputDiscriminatorType.Video,
                _ => null,
            };
        }
    }
}