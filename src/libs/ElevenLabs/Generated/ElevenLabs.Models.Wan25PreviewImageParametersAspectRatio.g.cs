
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 1:1
    /// </summary>
    public enum Wan25PreviewImageParametersAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Wan25PreviewImageParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Wan25PreviewImageParametersAspectRatio value)
        {
            return value switch
            {
                Wan25PreviewImageParametersAspectRatio.x16_9 => "16:9",
                Wan25PreviewImageParametersAspectRatio.x1_1 => "1:1",
                Wan25PreviewImageParametersAspectRatio.x3_4 => "3:4",
                Wan25PreviewImageParametersAspectRatio.x4_3 => "4:3",
                Wan25PreviewImageParametersAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Wan25PreviewImageParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => Wan25PreviewImageParametersAspectRatio.x16_9,
                "1:1" => Wan25PreviewImageParametersAspectRatio.x1_1,
                "3:4" => Wan25PreviewImageParametersAspectRatio.x3_4,
                "4:3" => Wan25PreviewImageParametersAspectRatio.x4_3,
                "9:16" => Wan25PreviewImageParametersAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}