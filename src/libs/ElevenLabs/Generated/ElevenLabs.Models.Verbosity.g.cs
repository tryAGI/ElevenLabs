
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum Verbosity
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Concise,
        /// <summary>
        /// 
        /// </summary>
        Thorough,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Verbosity value)
        {
            return value switch
            {
                Verbosity.Auto => "auto",
                Verbosity.Concise => "concise",
                Verbosity.Thorough => "thorough",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Verbosity? ToEnum(string value)
        {
            return value switch
            {
                "auto" => Verbosity.Auto,
                "concise" => Verbosity.Concise,
                "thorough" => Verbosity.Thorough,
                _ => null,
            };
        }
    }
}