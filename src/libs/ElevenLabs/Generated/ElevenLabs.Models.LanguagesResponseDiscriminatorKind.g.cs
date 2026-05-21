
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum LanguagesResponseDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        Pair,
        /// <summary>
        /// 
        /// </summary>
        Single,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguagesResponseDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguagesResponseDiscriminatorKind value)
        {
            return value switch
            {
                LanguagesResponseDiscriminatorKind.Pair => "pair",
                LanguagesResponseDiscriminatorKind.Single => "single",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguagesResponseDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "pair" => LanguagesResponseDiscriminatorKind.Pair,
                "single" => LanguagesResponseDiscriminatorKind.Single,
                _ => null,
            };
        }
    }
}