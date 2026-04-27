
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum VeedFabricTemplateParametersResolution
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
    public static class VeedFabricTemplateParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VeedFabricTemplateParametersResolution value)
        {
            return value switch
            {
                VeedFabricTemplateParametersResolution.x480p => "480p",
                VeedFabricTemplateParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VeedFabricTemplateParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => VeedFabricTemplateParametersResolution.x480p,
                "720p" => VeedFabricTemplateParametersResolution.x720p,
                _ => null,
            };
        }
    }
}