
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ConflictResolutionChoice
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Source,
        /// <summary>
        ///
        /// </summary>
        Target,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConflictResolutionChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConflictResolutionChoice value)
        {
            return value switch
            {
                ConflictResolutionChoice.Custom => "custom",
                ConflictResolutionChoice.Source => "source",
                ConflictResolutionChoice.Target => "target",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConflictResolutionChoice? ToEnum(string value)
        {
            return value switch
            {
                "custom" => ConflictResolutionChoice.Custom,
                "source" => ConflictResolutionChoice.Source,
                "target" => ConflictResolutionChoice.Target,
                _ => null,
            };
        }
    }
}