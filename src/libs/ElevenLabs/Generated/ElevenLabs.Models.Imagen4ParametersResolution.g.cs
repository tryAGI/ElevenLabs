
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 1K
    /// </summary>
    public enum Imagen4ParametersResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1k,
        /// <summary>
        /// 
        /// </summary>
        x2k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Imagen4ParametersResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Imagen4ParametersResolution value)
        {
            return value switch
            {
                Imagen4ParametersResolution.x1k => "1K",
                Imagen4ParametersResolution.x2k => "2K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Imagen4ParametersResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => Imagen4ParametersResolution.x1k,
                "2K" => Imagen4ParametersResolution.x2k,
                _ => null,
            };
        }
    }
}