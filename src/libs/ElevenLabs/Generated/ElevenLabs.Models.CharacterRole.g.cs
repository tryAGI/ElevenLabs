
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CharacterRole
    {
        /// <summary>
        /// 
        /// </summary>
        Main,
        /// <summary>
        /// 
        /// </summary>
        Minor,
        /// <summary>
        /// 
        /// </summary>
        Narrator,
        /// <summary>
        /// 
        /// </summary>
        Supporting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CharacterRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CharacterRole value)
        {
            return value switch
            {
                CharacterRole.Main => "main",
                CharacterRole.Minor => "minor",
                CharacterRole.Narrator => "narrator",
                CharacterRole.Supporting => "supporting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CharacterRole? ToEnum(string value)
        {
            return value switch
            {
                "main" => CharacterRole.Main,
                "minor" => CharacterRole.Minor,
                "narrator" => CharacterRole.Narrator,
                "supporting" => CharacterRole.Supporting,
                _ => null,
            };
        }
    }
}