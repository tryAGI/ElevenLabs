
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum KreaV2ParametersAspectRatio
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
        x235_1,
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
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x4_5,
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
    public static class KreaV2ParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KreaV2ParametersAspectRatio value)
        {
            return value switch
            {
                KreaV2ParametersAspectRatio.x16_9 => "16:9",
                KreaV2ParametersAspectRatio.x1_1 => "1:1",
                KreaV2ParametersAspectRatio.x235_1 => "2.35:1",
                KreaV2ParametersAspectRatio.x2_3 => "2:3",
                KreaV2ParametersAspectRatio.x3_2 => "3:2",
                KreaV2ParametersAspectRatio.x4_3 => "4:3",
                KreaV2ParametersAspectRatio.x4_5 => "4:5",
                KreaV2ParametersAspectRatio.x9_16 => "9:16",
                KreaV2ParametersAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KreaV2ParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => KreaV2ParametersAspectRatio.x16_9,
                "1:1" => KreaV2ParametersAspectRatio.x1_1,
                "2.35:1" => KreaV2ParametersAspectRatio.x235_1,
                "2:3" => KreaV2ParametersAspectRatio.x2_3,
                "3:2" => KreaV2ParametersAspectRatio.x3_2,
                "4:3" => KreaV2ParametersAspectRatio.x4_3,
                "4:5" => KreaV2ParametersAspectRatio.x4_5,
                "9:16" => KreaV2ParametersAspectRatio.x9_16,
                "auto" => KreaV2ParametersAspectRatio.Auto,
                _ => null,
            };
        }
    }
}