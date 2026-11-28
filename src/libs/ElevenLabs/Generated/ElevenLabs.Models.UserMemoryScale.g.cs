
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How much of a user's history an agent carries into the prompt.<br/>
    /// Default Value: balanced
    /// </summary>
    public enum UserMemoryScale
    {
        /// <summary>
        ///
        /// </summary>
        Balanced,
        /// <summary>
        ///
        /// </summary>
        Maximum,
        /// <summary>
        ///
        /// </summary>
        Minimal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserMemoryScaleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMemoryScale value)
        {
            return value switch
            {
                UserMemoryScale.Balanced => "balanced",
                UserMemoryScale.Maximum => "maximum",
                UserMemoryScale.Minimal => "minimal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMemoryScale? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => UserMemoryScale.Balanced,
                "maximum" => UserMemoryScale.Maximum,
                "minimal" => UserMemoryScale.Minimal,
                _ => null,
            };
        }
    }
}