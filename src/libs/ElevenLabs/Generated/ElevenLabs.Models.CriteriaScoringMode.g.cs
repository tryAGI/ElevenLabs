
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: binary
    /// </summary>
    public enum CriteriaScoringMode
    {
        /// <summary>
        /// 
        /// </summary>
        Binary,
        /// <summary>
        /// 
        /// </summary>
        NumericUniform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CriteriaScoringModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CriteriaScoringMode value)
        {
            return value switch
            {
                CriteriaScoringMode.Binary => "binary",
                CriteriaScoringMode.NumericUniform => "numeric_uniform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CriteriaScoringMode? ToEnum(string value)
        {
            return value switch
            {
                "binary" => CriteriaScoringMode.Binary,
                "numeric_uniform" => CriteriaScoringMode.NumericUniform,
                _ => null,
            };
        }
    }
}