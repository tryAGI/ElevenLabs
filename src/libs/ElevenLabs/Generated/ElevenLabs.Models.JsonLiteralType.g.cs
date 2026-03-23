
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// JSON schema literal types. e.g. all Json types except nested objects and lists
    /// </summary>
    public enum JsonLiteralType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
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
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JsonLiteralTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JsonLiteralType value)
        {
            return value switch
            {
                JsonLiteralType.Boolean => "boolean",
                JsonLiteralType.Integer => "integer",
                JsonLiteralType.Number => "number",
                JsonLiteralType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JsonLiteralType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => JsonLiteralType.Boolean,
                "integer" => JsonLiteralType.Integer,
                "number" => JsonLiteralType.Number,
                "string" => JsonLiteralType.String,
                _ => null,
            };
        }
    }
}