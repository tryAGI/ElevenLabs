
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CharacterGender
    {
        /// <summary>
        /// 
        /// </summary>
        Female,
        /// <summary>
        /// 
        /// </summary>
        Male,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CharacterGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CharacterGender value)
        {
            return value switch
            {
                CharacterGender.Female => "female",
                CharacterGender.Male => "male",
                CharacterGender.Neutral => "neutral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CharacterGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => CharacterGender.Female,
                "male" => CharacterGender.Male,
                "neutral" => CharacterGender.Neutral,
                _ => null,
            };
        }
    }
}