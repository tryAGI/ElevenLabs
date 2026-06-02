
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How lyrics are handled: auto-generated, custom-provided, or instrumental only.<br/>
    /// Default Value: auto
    /// </summary>
    public enum ElevenLabsMusicParametersLyricsType
    {
        /// <summary>
        /// auto-generated, custom-provided, or instrumental only.
        /// </summary>
        Auto,
        /// <summary>
        /// auto-generated, custom-provided, or instrumental only.
        /// </summary>
        Custom,
        /// <summary>
        /// auto-generated, custom-provided, or instrumental only.
        /// </summary>
        Instrumental,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsMusicParametersLyricsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsMusicParametersLyricsType value)
        {
            return value switch
            {
                ElevenLabsMusicParametersLyricsType.Auto => "auto",
                ElevenLabsMusicParametersLyricsType.Custom => "custom",
                ElevenLabsMusicParametersLyricsType.Instrumental => "instrumental",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsMusicParametersLyricsType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ElevenLabsMusicParametersLyricsType.Auto,
                "custom" => ElevenLabsMusicParametersLyricsType.Custom,
                "instrumental" => ElevenLabsMusicParametersLyricsType.Instrumental,
                _ => null,
            };
        }
    }
}