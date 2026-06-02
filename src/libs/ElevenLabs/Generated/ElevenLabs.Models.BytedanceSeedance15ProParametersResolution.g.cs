
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum BytedanceSeedance15ProParametersResolution
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
    public static class BytedanceSeedance15ProParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedance15ProParametersResolution value)
        {
            return value switch
            {
                BytedanceSeedance15ProParametersResolution.x480p => "480p",
                BytedanceSeedance15ProParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedance15ProParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => BytedanceSeedance15ProParametersResolution.x480p,
                "720p" => BytedanceSeedance15ProParametersResolution.x720p,
                _ => null,
            };
        }
    }
}