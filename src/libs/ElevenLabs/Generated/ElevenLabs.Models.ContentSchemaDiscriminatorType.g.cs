
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ContentSchemaDiscriminatorType
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
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentSchemaDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentSchemaDiscriminatorType value)
        {
            return value switch
            {
                ContentSchemaDiscriminatorType.Array => "array",
                ContentSchemaDiscriminatorType.Audio => "audio",
                ContentSchemaDiscriminatorType.Boolean => "boolean",
                ContentSchemaDiscriminatorType.Image => "image",
                ContentSchemaDiscriminatorType.Integer => "integer",
                ContentSchemaDiscriminatorType.Number => "number",
                ContentSchemaDiscriminatorType.Object => "object",
                ContentSchemaDiscriminatorType.String => "string",
                ContentSchemaDiscriminatorType.Video => "video",
                ContentSchemaDiscriminatorType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentSchemaDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "array" => ContentSchemaDiscriminatorType.Array,
                "audio" => ContentSchemaDiscriminatorType.Audio,
                "boolean" => ContentSchemaDiscriminatorType.Boolean,
                "image" => ContentSchemaDiscriminatorType.Image,
                "integer" => ContentSchemaDiscriminatorType.Integer,
                "number" => ContentSchemaDiscriminatorType.Number,
                "object" => ContentSchemaDiscriminatorType.Object,
                "string" => ContentSchemaDiscriminatorType.String,
                "video" => ContentSchemaDiscriminatorType.Video,
                "voice" => ContentSchemaDiscriminatorType.Voice,
                _ => null,
            };
        }
    }
}