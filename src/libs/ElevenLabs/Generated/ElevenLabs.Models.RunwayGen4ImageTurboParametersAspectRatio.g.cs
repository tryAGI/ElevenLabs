
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum RunwayGen4ImageTurboParametersAspectRatio
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
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunwayGen4ImageTurboParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunwayGen4ImageTurboParametersAspectRatio value)
        {
            return value switch
            {
                RunwayGen4ImageTurboParametersAspectRatio.x16_9 => "16:9",
                RunwayGen4ImageTurboParametersAspectRatio.x1_1 => "1:1",
                RunwayGen4ImageTurboParametersAspectRatio.x3_4 => "3:4",
                RunwayGen4ImageTurboParametersAspectRatio.x4_3 => "4:3",
                RunwayGen4ImageTurboParametersAspectRatio.x9_16 => "9:16",
                RunwayGen4ImageTurboParametersAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunwayGen4ImageTurboParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => RunwayGen4ImageTurboParametersAspectRatio.x16_9,
                "1:1" => RunwayGen4ImageTurboParametersAspectRatio.x1_1,
                "3:4" => RunwayGen4ImageTurboParametersAspectRatio.x3_4,
                "4:3" => RunwayGen4ImageTurboParametersAspectRatio.x4_3,
                "9:16" => RunwayGen4ImageTurboParametersAspectRatio.x9_16,
                "auto" => RunwayGen4ImageTurboParametersAspectRatio.Auto,
                _ => null,
            };
        }
    }
}