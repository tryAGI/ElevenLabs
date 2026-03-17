
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMLiteralJsonSchemaPropertyType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        Integer,
        /// <summary>
        /// 
        /// </summary>
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMLiteralJsonSchemaPropertyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMLiteralJsonSchemaPropertyType value)
        {
            return value switch
            {
                LLMLiteralJsonSchemaPropertyType.Boolean => "boolean",
                LLMLiteralJsonSchemaPropertyType.String => "string",
                LLMLiteralJsonSchemaPropertyType.Integer => "integer",
                LLMLiteralJsonSchemaPropertyType.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMLiteralJsonSchemaPropertyType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => LLMLiteralJsonSchemaPropertyType.Boolean,
                "string" => LLMLiteralJsonSchemaPropertyType.String,
                "integer" => LLMLiteralJsonSchemaPropertyType.Integer,
                "number" => LLMLiteralJsonSchemaPropertyType.Number,
                _ => null,
            };
        }
    }
}