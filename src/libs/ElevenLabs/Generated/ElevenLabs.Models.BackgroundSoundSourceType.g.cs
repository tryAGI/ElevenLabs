
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The type of background sound source.
    /// </summary>
    public enum BackgroundSoundSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Preset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundSoundSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundSoundSourceType value)
        {
            return value switch
            {
                BackgroundSoundSourceType.Preset => "preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundSoundSourceType? ToEnum(string value)
        {
            return value switch
            {
                "preset" => BackgroundSoundSourceType.Preset,
                _ => null,
            };
        }
    }
}