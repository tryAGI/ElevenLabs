
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
                LLMLiteralJsonSchemaPropertyType.Integer => "integer",
                LLMLiteralJsonSchemaPropertyType.Number => "number",
                LLMLiteralJsonSchemaPropertyType.String => "string",
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
                "integer" => LLMLiteralJsonSchemaPropertyType.Integer,
                "number" => LLMLiteralJsonSchemaPropertyType.Number,
                "string" => LLMLiteralJsonSchemaPropertyType.String,
                _ => null,
            };
        }
    }
}