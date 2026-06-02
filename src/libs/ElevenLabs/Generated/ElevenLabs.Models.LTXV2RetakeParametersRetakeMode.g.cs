
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: replace_audio_and_video
    /// </summary>
    public enum LTXV2RetakeParametersRetakeMode
    {
        /// <summary>
        /// 
        /// </summary>
        ReplaceAudio,
        /// <summary>
        /// 
        /// </summary>
        ReplaceAudioAndVideo,
        /// <summary>
        /// 
        /// </summary>
        ReplaceVideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LTXV2RetakeParametersRetakeModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LTXV2RetakeParametersRetakeMode value)
        {
            return value switch
            {
                LTXV2RetakeParametersRetakeMode.ReplaceAudio => "replace_audio",
                LTXV2RetakeParametersRetakeMode.ReplaceAudioAndVideo => "replace_audio_and_video",
                LTXV2RetakeParametersRetakeMode.ReplaceVideo => "replace_video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LTXV2RetakeParametersRetakeMode? ToEnum(string value)
        {
            return value switch
            {
                "replace_audio" => LTXV2RetakeParametersRetakeMode.ReplaceAudio,
                "replace_audio_and_video" => LTXV2RetakeParametersRetakeMode.ReplaceAudioAndVideo,
                "replace_video" => LTXV2RetakeParametersRetakeMode.ReplaceVideo,
                _ => null,
            };
        }
    }
}