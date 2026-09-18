
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output image.<br/>
    /// Default Value: 1K
    /// </summary>
    public enum GPTImage25SunburstRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
        /// <summary>
        ///
        /// </summary>
        x4k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPTImage25SunburstRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage25SunburstRequestResolution value)
        {
            return value switch
            {
                GPTImage25SunburstRequestResolution.x1k => "1K",
                GPTImage25SunburstRequestResolution.x2k => "2K",
                GPTImage25SunburstRequestResolution.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage25SunburstRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => GPTImage25SunburstRequestResolution.x1k,
                "2K" => GPTImage25SunburstRequestResolution.x2k,
                "4K" => GPTImage25SunburstRequestResolution.x4k,
                _ => null,
            };
        }
    }
}