
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalysisPropertyType
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
    public static class AnalysisPropertyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalysisPropertyType value)
        {
            return value switch
            {
                AnalysisPropertyType.Boolean => "boolean",
                AnalysisPropertyType.Integer => "integer",
                AnalysisPropertyType.Number => "number",
                AnalysisPropertyType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalysisPropertyType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AnalysisPropertyType.Boolean,
                "integer" => AnalysisPropertyType.Integer,
                "number" => AnalysisPropertyType.Number,
                "string" => AnalysisPropertyType.String,
                _ => null,
            };
        }
    }
}