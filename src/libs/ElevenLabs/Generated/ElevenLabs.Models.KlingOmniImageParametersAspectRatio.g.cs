
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum KlingOmniImageParametersAspectRatio
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
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KlingOmniImageParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KlingOmniImageParametersAspectRatio value)
        {
            return value switch
            {
                KlingOmniImageParametersAspectRatio.x16_9 => "16:9",
                KlingOmniImageParametersAspectRatio.x1_1 => "1:1",
                KlingOmniImageParametersAspectRatio.x21_9 => "21:9",
                KlingOmniImageParametersAspectRatio.x2_3 => "2:3",
                KlingOmniImageParametersAspectRatio.x3_2 => "3:2",
                KlingOmniImageParametersAspectRatio.x3_4 => "3:4",
                KlingOmniImageParametersAspectRatio.x4_3 => "4:3",
                KlingOmniImageParametersAspectRatio.x9_16 => "9:16",
                KlingOmniImageParametersAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KlingOmniImageParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => KlingOmniImageParametersAspectRatio.x16_9,
                "1:1" => KlingOmniImageParametersAspectRatio.x1_1,
                "21:9" => KlingOmniImageParametersAspectRatio.x21_9,
                "2:3" => KlingOmniImageParametersAspectRatio.x2_3,
                "3:2" => KlingOmniImageParametersAspectRatio.x3_2,
                "3:4" => KlingOmniImageParametersAspectRatio.x3_4,
                "4:3" => KlingOmniImageParametersAspectRatio.x4_3,
                "9:16" => KlingOmniImageParametersAspectRatio.x9_16,
                "auto" => KlingOmniImageParametersAspectRatio.Auto,
                _ => null,
            };
        }
    }
}