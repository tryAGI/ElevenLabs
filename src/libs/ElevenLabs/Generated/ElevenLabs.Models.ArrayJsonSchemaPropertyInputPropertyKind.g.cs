
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: array
    /// </summary>
    public enum ArrayJsonSchemaPropertyInputPropertyKind
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
    public static class ArrayJsonSchemaPropertyInputPropertyKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArrayJsonSchemaPropertyInputPropertyKind value)
        {
            return value switch
            {
                ArrayJsonSchemaPropertyInputPropertyKind.Array => "array",
                ArrayJsonSchemaPropertyInputPropertyKind.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArrayJsonSchemaPropertyInputPropertyKind? ToEnum(string value)
        {
            return value switch
            {
                "array" => ArrayJsonSchemaPropertyInputPropertyKind.Array,
                "object" => ArrayJsonSchemaPropertyInputPropertyKind.Object,
                _ => null,
            };
        }
    }
}