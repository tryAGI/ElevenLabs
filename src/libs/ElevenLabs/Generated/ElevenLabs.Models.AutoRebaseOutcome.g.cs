
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoRebaseOutcome
    {
        /// <summary>
        ///
        /// </summary>
        Conflict,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        NoCommonAncestor,
        /// <summary>
        ///
        /// </summary>
        Rejected,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoRebaseOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoRebaseOutcome value)
        {
            return value switch
            {
                AutoRebaseOutcome.Conflict => "conflict",
                AutoRebaseOutcome.Error => "error",
                AutoRebaseOutcome.NoCommonAncestor => "no_common_ancestor",
                AutoRebaseOutcome.Rejected => "rejected",
                AutoRebaseOutcome.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoRebaseOutcome? ToEnum(string value)
        {
            return value switch
            {
                "conflict" => AutoRebaseOutcome.Conflict,
                "error" => AutoRebaseOutcome.Error,
                "no_common_ancestor" => AutoRebaseOutcome.NoCommonAncestor,
                "rejected" => AutoRebaseOutcome.Rejected,
                "succeeded" => AutoRebaseOutcome.Succeeded,
                _ => null,
            };
        }
    }
}