
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: object
    /// </summary>
    public enum ObjectJsonSchemaPropertyInputPropertyKind
    {
        /// <summary>
        /// 
        /// </summary>
        Array,
        /// <summary>
        /// 
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObjectJsonSchemaPropertyInputPropertyKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectJsonSchemaPropertyInputPropertyKind value)
        {
            return value switch
            {
                ObjectJsonSchemaPropertyInputPropertyKind.Array => "array",
                ObjectJsonSchemaPropertyInputPropertyKind.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectJsonSchemaPropertyInputPropertyKind? ToEnum(string value)
        {
            return value switch
            {
                "array" => ObjectJsonSchemaPropertyInputPropertyKind.Array,
                "object" => ObjectJsonSchemaPropertyInputPropertyKind.Object,
                _ => null,
            };
        }
    }
}