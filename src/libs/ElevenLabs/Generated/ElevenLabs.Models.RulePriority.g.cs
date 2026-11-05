
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: strict
    /// </summary>
    public enum RulePriority
    {
        /// <summary>
        ///
        /// </summary>
        Strict,
        /// <summary>
        ///
        /// </summary>
        Suggestion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RulePriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RulePriority value)
        {
            return value switch
            {
                RulePriority.Strict => "strict",
                RulePriority.Suggestion => "suggestion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RulePriority? ToEnum(string value)
        {
            return value switch
            {
                "strict" => RulePriority.Strict,
                "suggestion" => RulePriority.Suggestion,
                _ => null,
            };
        }
    }
}