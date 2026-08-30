
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: eleven_text_to_sound_v2
    /// </summary>
    public enum SFXModelId
    {
        /// <summary>
        ///
        /// </summary>
        ElevenTextToSoundV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SFXModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SFXModelId value)
        {
            return value switch
            {
                SFXModelId.ElevenTextToSoundV2 => "eleven_text_to_sound_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SFXModelId? ToEnum(string value)
        {
            return value switch
            {
                "eleven_text_to_sound_v2" => SFXModelId.ElevenTextToSoundV2,
                _ => null,
            };
        }
    }
}