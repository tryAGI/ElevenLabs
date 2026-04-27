
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum LTXAudioToVideoTemplateParametersResolution2
    {
        /// <summary>
        /// 
        /// </summary>
        x1k,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LTXAudioToVideoTemplateParametersResolution2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LTXAudioToVideoTemplateParametersResolution2 value)
        {
            return value switch
            {
                LTXAudioToVideoTemplateParametersResolution2.x1k => "1K",
                LTXAudioToVideoTemplateParametersResolution2.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LTXAudioToVideoTemplateParametersResolution2? ToEnum(string value)
        {
            return value switch
            {
                "1K" => LTXAudioToVideoTemplateParametersResolution2.x1k,
                "720p" => LTXAudioToVideoTemplateParametersResolution2.x720p,
                _ => null,
            };
        }
    }
}