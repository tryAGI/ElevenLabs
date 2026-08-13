
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output image.<br/>
    /// Default Value: 1K
    /// </summary>
    public enum GPTImage2RequestResolution
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
    public static class GPTImage2RequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImage2RequestResolution value)
        {
            return value switch
            {
                GPTImage2RequestResolution.x1k => "1K",
                GPTImage2RequestResolution.x2k => "2K",
                GPTImage2RequestResolution.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImage2RequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => GPTImage2RequestResolution.x1k,
                "2K" => GPTImage2RequestResolution.x2k,
                "4K" => GPTImage2RequestResolution.x4k,
                _ => null,
            };
        }
    }
}