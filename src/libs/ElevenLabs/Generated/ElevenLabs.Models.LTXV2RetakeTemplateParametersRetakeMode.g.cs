
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: replace_audio_and_video
    /// </summary>
    public enum LTXV2RetakeTemplateParametersRetakeMode
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
    public static class LTXV2RetakeTemplateParametersRetakeModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LTXV2RetakeTemplateParametersRetakeMode value)
        {
            return value switch
            {
                LTXV2RetakeTemplateParametersRetakeMode.ReplaceAudio => "replace_audio",
                LTXV2RetakeTemplateParametersRetakeMode.ReplaceAudioAndVideo => "replace_audio_and_video",
                LTXV2RetakeTemplateParametersRetakeMode.ReplaceVideo => "replace_video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LTXV2RetakeTemplateParametersRetakeMode? ToEnum(string value)
        {
            return value switch
            {
                "replace_audio" => LTXV2RetakeTemplateParametersRetakeMode.ReplaceAudio,
                "replace_audio_and_video" => LTXV2RetakeTemplateParametersRetakeMode.ReplaceAudioAndVideo,
                "replace_video" => LTXV2RetakeTemplateParametersRetakeMode.ReplaceVideo,
                _ => null,
            };
        }
    }
}