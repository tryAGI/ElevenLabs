
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: array
    /// </summary>
    public enum QueryArrayJsonSchemaPropertyInputPropertyKind
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
    public static class QueryArrayJsonSchemaPropertyInputPropertyKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryArrayJsonSchemaPropertyInputPropertyKind value)
        {
            return value switch
            {
                QueryArrayJsonSchemaPropertyInputPropertyKind.Array => "array",
                QueryArrayJsonSchemaPropertyInputPropertyKind.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryArrayJsonSchemaPropertyInputPropertyKind? ToEnum(string value)
        {
            return value switch
            {
                "array" => QueryArrayJsonSchemaPropertyInputPropertyKind.Array,
                "object" => QueryArrayJsonSchemaPropertyInputPropertyKind.Object,
                _ => null,
            };
        }
    }
}