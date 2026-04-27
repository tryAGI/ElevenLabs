
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: png
    /// </summary>
    public enum Flux2ProParametersOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Jpeg,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux2ProParametersOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux2ProParametersOutputFormat value)
        {
            return value switch
            {
                Flux2ProParametersOutputFormat.Jpeg => "jpeg",
                Flux2ProParametersOutputFormat.Png => "png",
                Flux2ProParametersOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux2ProParametersOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => Flux2ProParametersOutputFormat.Jpeg,
                "png" => Flux2ProParametersOutputFormat.Png,
                "webp" => Flux2ProParametersOutputFormat.Webp,
                _ => null,
            };
        }
    }
}