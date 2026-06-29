
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CharacterAge
    {
        /// <summary>
        /// 
        /// </summary>
        MiddleAged,
        /// <summary>
        /// 
        /// </summary>
        Old,
        /// <summary>
        /// 
        /// </summary>
        Young,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CharacterAgeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CharacterAge value)
        {
            return value switch
            {
                CharacterAge.MiddleAged => "middle-aged",
                CharacterAge.Old => "old",
                CharacterAge.Young => "young",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CharacterAge? ToEnum(string value)
        {
            return value switch
            {
                "middle-aged" => CharacterAge.MiddleAged,
                "old" => CharacterAge.Old,
                "young" => CharacterAge.Young,
                _ => null,
            };
        }
    }
}