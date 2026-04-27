
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum Kling25TurboParametersAspectRatio2
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
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Kling25TurboParametersAspectRatio2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Kling25TurboParametersAspectRatio2 value)
        {
            return value switch
            {
                Kling25TurboParametersAspectRatio2.x16_9 => "16:9",
                Kling25TurboParametersAspectRatio2.x1_1 => "1:1",
                Kling25TurboParametersAspectRatio2.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Kling25TurboParametersAspectRatio2? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => Kling25TurboParametersAspectRatio2.x16_9,
                "1:1" => Kling25TurboParametersAspectRatio2.x1_1,
                "9:16" => Kling25TurboParametersAspectRatio2.x9_16,
                _ => null,
            };
        }
    }
}