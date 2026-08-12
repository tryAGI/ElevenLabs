
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The aspect ratio of the output video. With `auto`, the model picks an aspect ratio based on the inputs.<br/>
    /// Default Value: 16:9
    /// </summary>
    public enum BytedanceSeedance2RequestAspectRatio
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
    public static class BytedanceSeedance2RequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BytedanceSeedance2RequestAspectRatio value)
        {
            return value switch
            {
                BytedanceSeedance2RequestAspectRatio.x16_9 => "16:9",
                BytedanceSeedance2RequestAspectRatio.x1_1 => "1:1",
                BytedanceSeedance2RequestAspectRatio.x21_9 => "21:9",
                BytedanceSeedance2RequestAspectRatio.x3_4 => "3:4",
                BytedanceSeedance2RequestAspectRatio.x4_3 => "4:3",
                BytedanceSeedance2RequestAspectRatio.x9_16 => "9:16",
                BytedanceSeedance2RequestAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BytedanceSeedance2RequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => BytedanceSeedance2RequestAspectRatio.x16_9,
                "1:1" => BytedanceSeedance2RequestAspectRatio.x1_1,
                "21:9" => BytedanceSeedance2RequestAspectRatio.x21_9,
                "3:4" => BytedanceSeedance2RequestAspectRatio.x3_4,
                "4:3" => BytedanceSeedance2RequestAspectRatio.x4_3,
                "9:16" => BytedanceSeedance2RequestAspectRatio.x9_16,
                "auto" => BytedanceSeedance2RequestAspectRatio.Auto,
                _ => null,
            };
        }
    }
}