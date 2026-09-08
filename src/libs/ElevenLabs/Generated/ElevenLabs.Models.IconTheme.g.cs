
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum IconTheme
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
    public static class IconThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IconTheme value)
        {
            return value switch
            {
                IconTheme.Dark => "dark",
                IconTheme.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IconTheme? ToEnum(string value)
        {
            return value switch
            {
                "dark" => IconTheme.Dark,
                "light" => IconTheme.Light,
                _ => null,
            };
        }
    }
}