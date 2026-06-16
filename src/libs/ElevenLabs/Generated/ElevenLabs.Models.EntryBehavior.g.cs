
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum EntryBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        GenerateImmediately,
        /// <summary>
        /// 
        /// </summary>
        WaitForUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntryBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntryBehavior value)
        {
            return value switch
            {
                EntryBehavior.Auto => "auto",
                EntryBehavior.GenerateImmediately => "generate_immediately",
                EntryBehavior.WaitForUser => "wait_for_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntryBehavior? ToEnum(string value)
        {
            return value switch
            {
                "auto" => EntryBehavior.Auto,
                "generate_immediately" => EntryBehavior.GenerateImmediately,
                "wait_for_user" => EntryBehavior.WaitForUser,
                _ => null,
            };
        }
    }
}