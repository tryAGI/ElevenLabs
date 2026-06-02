
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 1:1
    /// </summary>
    public enum GPTImageParametersAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GPTImageParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GPTImageParametersAspectRatio value)
        {
            return value switch
            {
                GPTImageParametersAspectRatio.x1_1 => "1:1",
                GPTImageParametersAspectRatio.x2_3 => "2:3",
                GPTImageParametersAspectRatio.x3_2 => "3:2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GPTImageParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "1:1" => GPTImageParametersAspectRatio.x1_1,
                "2:3" => GPTImageParametersAspectRatio.x2_3,
                "3:2" => GPTImageParametersAspectRatio.x3_2,
                _ => null,
            };
        }
    }
}