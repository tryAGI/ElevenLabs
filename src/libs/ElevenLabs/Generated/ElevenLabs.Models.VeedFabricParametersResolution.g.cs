
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 720p
    /// </summary>
    public enum VeedFabricParametersResolution
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
    public static class VeedFabricParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VeedFabricParametersResolution value)
        {
            return value switch
            {
                VeedFabricParametersResolution.x480p => "480p",
                VeedFabricParametersResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VeedFabricParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "480p" => VeedFabricParametersResolution.x480p,
                "720p" => VeedFabricParametersResolution.x720p,
                _ => null,
            };
        }
    }
}