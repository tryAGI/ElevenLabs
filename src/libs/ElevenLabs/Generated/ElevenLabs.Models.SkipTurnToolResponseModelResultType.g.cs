
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: skip_turn_success
    /// </summary>
    public enum SkipTurnToolResponseModelResultType
    {
        /// <summary>
        /// 
        /// </summary>
        SkipTurnSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkipTurnToolResponseModelResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkipTurnToolResponseModelResultType value)
        {
            return value switch
            {
                SkipTurnToolResponseModelResultType.SkipTurnSuccess => "skip_turn_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkipTurnToolResponseModelResultType? ToEnum(string value)
        {
            return value switch
            {
                "skip_turn_success" => SkipTurnToolResponseModelResultType.SkipTurnSuccess,
                _ => null,
            };
        }
    }
}