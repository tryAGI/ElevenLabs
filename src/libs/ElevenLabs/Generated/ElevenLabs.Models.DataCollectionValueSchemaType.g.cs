
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum DataCollectionValueSchemaType
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
    public static class DataCollectionValueSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataCollectionValueSchemaType value)
        {
            return value switch
            {
                DataCollectionValueSchemaType.Boolean => "boolean",
                DataCollectionValueSchemaType.Integer => "integer",
                DataCollectionValueSchemaType.Number => "number",
                DataCollectionValueSchemaType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataCollectionValueSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => DataCollectionValueSchemaType.Boolean,
                "integer" => DataCollectionValueSchemaType.Integer,
                "number" => DataCollectionValueSchemaType.Number,
                "string" => DataCollectionValueSchemaType.String,
                _ => null,
            };
        }
    }
}