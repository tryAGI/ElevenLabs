
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum MusicGenerationMode
    {
        /// <summary>
        /// 
        /// </summary>
        Ambience,
        /// <summary>
        /// 
        /// </summary>
        Loop,
        /// <summary>
        /// 
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MusicGenerationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MusicGenerationMode value)
        {
            return value switch
            {
                MusicGenerationMode.Ambience => "ambience",
                MusicGenerationMode.Loop => "loop",
                MusicGenerationMode.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MusicGenerationMode? ToEnum(string value)
        {
            return value switch
            {
                "ambience" => MusicGenerationMode.Ambience,
                "loop" => MusicGenerationMode.Loop,
                "track" => MusicGenerationMode.Track,
                _ => null,
            };
        }
    }
}