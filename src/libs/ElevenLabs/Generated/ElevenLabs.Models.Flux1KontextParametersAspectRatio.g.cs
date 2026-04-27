
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum Flux1KontextParametersAspectRatio
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
        x21_9,
        /// <summary>
        /// 
        /// </summary>
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
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
        /// <summary>
        /// 
        /// </summary>
        x9_21,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux1KontextParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux1KontextParametersAspectRatio value)
        {
            return value switch
            {
                Flux1KontextParametersAspectRatio.x16_9 => "16:9",
                Flux1KontextParametersAspectRatio.x1_1 => "1:1",
                Flux1KontextParametersAspectRatio.x21_9 => "21:9",
                Flux1KontextParametersAspectRatio.x2_3 => "2:3",
                Flux1KontextParametersAspectRatio.x3_2 => "3:2",
                Flux1KontextParametersAspectRatio.x3_4 => "3:4",
                Flux1KontextParametersAspectRatio.x4_3 => "4:3",
                Flux1KontextParametersAspectRatio.x9_16 => "9:16",
                Flux1KontextParametersAspectRatio.x9_21 => "9:21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux1KontextParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => Flux1KontextParametersAspectRatio.x16_9,
                "1:1" => Flux1KontextParametersAspectRatio.x1_1,
                "21:9" => Flux1KontextParametersAspectRatio.x21_9,
                "2:3" => Flux1KontextParametersAspectRatio.x2_3,
                "3:2" => Flux1KontextParametersAspectRatio.x3_2,
                "3:4" => Flux1KontextParametersAspectRatio.x3_4,
                "4:3" => Flux1KontextParametersAspectRatio.x4_3,
                "9:16" => Flux1KontextParametersAspectRatio.x9_16,
                "9:21" => Flux1KontextParametersAspectRatio.x9_21,
                _ => null,
            };
        }
    }
}