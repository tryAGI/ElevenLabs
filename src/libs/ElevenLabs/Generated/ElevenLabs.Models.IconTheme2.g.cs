
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum IconTheme2
    {
        /// <summary>
        ///
        /// </summary>
        Dark,
        /// <summary>
        ///
        /// </summary>
        Light,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IconTheme2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IconTheme2 value)
        {
            return value switch
            {
                IconTheme2.Dark => "dark",
                IconTheme2.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IconTheme2? ToEnum(string value)
        {
            return value switch
            {
                "dark" => IconTheme2.Dark,
                "light" => IconTheme2.Light,
                _ => null,
            };
        }
    }
}