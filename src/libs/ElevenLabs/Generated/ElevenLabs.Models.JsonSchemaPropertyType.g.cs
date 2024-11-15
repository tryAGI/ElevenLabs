
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum JsonSchemaPropertyType
    {
        /// <summary>
        /// 
        /// </summary>
        Object,
        /// <summary>
        /// 
        /// </summary>
        Array,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JsonSchemaPropertyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JsonSchemaPropertyType value)
        {
            return value switch
            {
                JsonSchemaPropertyType.Object => "object",
                JsonSchemaPropertyType.Array => "array",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JsonSchemaPropertyType? ToEnum(string value)
        {
            return value switch
            {
                "object" => JsonSchemaPropertyType.Object,
                "array" => JsonSchemaPropertyType.Array,
                _ => null,
            };
        }
    }
}