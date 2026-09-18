
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output image.<br/>
    /// Default Value: 1K
    /// </summary>
    public enum GPTImage25FlareRequestResolution
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
    public static class GPTImage25FlareRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage25FlareRequestResolution value)
        {
            return value switch
            {
                GPTImage25FlareRequestResolution.x1k => "1K",
                GPTImage25FlareRequestResolution.x2k => "2K",
                GPTImage25FlareRequestResolution.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage25FlareRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => GPTImage25FlareRequestResolution.x1k,
                "2K" => GPTImage25FlareRequestResolution.x2k,
                "4K" => GPTImage25FlareRequestResolution.x4k,
                _ => null,
            };
        }
    }
}