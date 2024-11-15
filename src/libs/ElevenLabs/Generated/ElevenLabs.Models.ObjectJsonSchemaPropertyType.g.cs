
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: object
    /// </summary>
    public enum ObjectJsonSchemaPropertyType
    {
        /// <summary>
        /// 
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObjectJsonSchemaPropertyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectJsonSchemaPropertyType value)
        {
            return value switch
            {
                ObjectJsonSchemaPropertyType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectJsonSchemaPropertyType? ToEnum(string value)
        {
            return value switch
            {
                "object" => ObjectJsonSchemaPropertyType.Object,
                _ => null,
            };
        }
    }
}