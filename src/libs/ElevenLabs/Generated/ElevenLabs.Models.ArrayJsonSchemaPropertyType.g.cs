
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: array
    /// </summary>
    public enum ArrayJsonSchemaPropertyType
    {
        /// <summary>
        /// 
        /// </summary>
        Array,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArrayJsonSchemaPropertyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArrayJsonSchemaPropertyType value)
        {
            return value switch
            {
                ArrayJsonSchemaPropertyType.Array => "array",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArrayJsonSchemaPropertyType? ToEnum(string value)
        {
            return value switch
            {
                "array" => ArrayJsonSchemaPropertyType.Array,
                _ => null,
            };
        }
    }
}