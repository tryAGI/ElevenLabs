
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum Flux2ProParametersAspectRatio
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
    public static class Flux2ProParametersAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux2ProParametersAspectRatio value)
        {
            return value switch
            {
                Flux2ProParametersAspectRatio.x16_9 => "16:9",
                Flux2ProParametersAspectRatio.x1_1 => "1:1",
                Flux2ProParametersAspectRatio.x3_4 => "3:4",
                Flux2ProParametersAspectRatio.x4_3 => "4:3",
                Flux2ProParametersAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux2ProParametersAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => Flux2ProParametersAspectRatio.x16_9,
                "1:1" => Flux2ProParametersAspectRatio.x1_1,
                "3:4" => Flux2ProParametersAspectRatio.x3_4,
                "4:3" => Flux2ProParametersAspectRatio.x4_3,
                "9:16" => Flux2ProParametersAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}