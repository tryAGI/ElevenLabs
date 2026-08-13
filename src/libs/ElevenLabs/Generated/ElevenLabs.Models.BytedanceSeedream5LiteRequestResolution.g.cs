
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output image.<br/>
    /// Default Value: 2K
    /// </summary>
    public enum BytedanceSeedream5LiteRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x2k,
        /// <summary>
        /// 
        /// </summary>
        x3k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BytedanceSeedream5LiteRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedream5LiteRequestResolution value)
        {
            return value switch
            {
                BytedanceSeedream5LiteRequestResolution.x2k => "2K",
                BytedanceSeedream5LiteRequestResolution.x3k => "3K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedream5LiteRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "2K" => BytedanceSeedream5LiteRequestResolution.x2k,
                "3K" => BytedanceSeedream5LiteRequestResolution.x3k,
                _ => null,
            };
        }
    }
}