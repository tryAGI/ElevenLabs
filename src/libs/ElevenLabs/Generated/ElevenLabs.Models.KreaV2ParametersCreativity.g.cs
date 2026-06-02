
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: medium
    /// </summary>
    public enum KreaV2ParametersCreativity
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Raw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KreaV2ParametersCreativityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KreaV2ParametersCreativity value)
        {
            return value switch
            {
                KreaV2ParametersCreativity.High => "high",
                KreaV2ParametersCreativity.Low => "low",
                KreaV2ParametersCreativity.Medium => "medium",
                KreaV2ParametersCreativity.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KreaV2ParametersCreativity? ToEnum(string value)
        {
            return value switch
            {
                "high" => KreaV2ParametersCreativity.High,
                "low" => KreaV2ParametersCreativity.Low,
                "medium" => KreaV2ParametersCreativity.Medium,
                "raw" => KreaV2ParametersCreativity.Raw,
                _ => null,
            };
        }
    }
}