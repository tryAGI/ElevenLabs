
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: png
    /// </summary>
    public enum KlingOmniImageParametersOutputFormat
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
    public static class KlingOmniImageParametersOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KlingOmniImageParametersOutputFormat value)
        {
            return value switch
            {
                KlingOmniImageParametersOutputFormat.Jpeg => "jpeg",
                KlingOmniImageParametersOutputFormat.Png => "png",
                KlingOmniImageParametersOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KlingOmniImageParametersOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => KlingOmniImageParametersOutputFormat.Jpeg,
                "png" => KlingOmniImageParametersOutputFormat.Png,
                "webp" => KlingOmniImageParametersOutputFormat.Webp,
                _ => null,
            };
        }
    }
}