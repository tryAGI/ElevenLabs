
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum Wan26ParametersAspectRatio2
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
    public static class Wan26ParametersAspectRatio2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Wan26ParametersAspectRatio2 value)
        {
            return value switch
            {
                Wan26ParametersAspectRatio2.x16_9 => "16:9",
                Wan26ParametersAspectRatio2.x1_1 => "1:1",
                Wan26ParametersAspectRatio2.x3_4 => "3:4",
                Wan26ParametersAspectRatio2.x4_3 => "4:3",
                Wan26ParametersAspectRatio2.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Wan26ParametersAspectRatio2? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => Wan26ParametersAspectRatio2.x16_9,
                "1:1" => Wan26ParametersAspectRatio2.x1_1,
                "3:4" => Wan26ParametersAspectRatio2.x3_4,
                "4:3" => Wan26ParametersAspectRatio2.x4_3,
                "9:16" => Wan26ParametersAspectRatio2.x9_16,
                _ => null,
            };
        }
    }
}