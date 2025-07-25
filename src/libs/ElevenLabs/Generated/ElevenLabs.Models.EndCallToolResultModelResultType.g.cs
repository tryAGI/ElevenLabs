
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: end_call_success
    /// </summary>
    public enum EndCallToolResultModelResultType
    {
        /// <summary>
        /// 
        /// </summary>
        EndCallSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndCallToolResultModelResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndCallToolResultModelResultType value)
        {
            return value switch
            {
                EndCallToolResultModelResultType.EndCallSuccess => "end_call_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndCallToolResultModelResultType? ToEnum(string value)
        {
            return value switch
            {
                "end_call_success" => EndCallToolResultModelResultType.EndCallSuccess,
                _ => null,
            };
        }
    }
}