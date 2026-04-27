
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum CreatifyAuroraTemplateParametersResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x480p,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatifyAuroraTemplateParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatifyAuroraTemplateParametersResolution value)
        {
            return value switch
            {
                CreatifyAuroraTemplateParametersResolution.x480p => "480p",
                CreatifyAuroraTemplateParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatifyAuroraTemplateParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => CreatifyAuroraTemplateParametersResolution.x480p,
                "720p" => CreatifyAuroraTemplateParametersResolution.x720p,
                _ => null,
            };
        }
    }
}