
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum Kling3ProParametersAspectRatio2
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
    public static class Kling3ProParametersAspectRatio2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Kling3ProParametersAspectRatio2 value)
        {
            return value switch
            {
                Kling3ProParametersAspectRatio2.x16_9 => "16:9",
                Kling3ProParametersAspectRatio2.x1_1 => "1:1",
                Kling3ProParametersAspectRatio2.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Kling3ProParametersAspectRatio2? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => Kling3ProParametersAspectRatio2.x16_9,
                "1:1" => Kling3ProParametersAspectRatio2.x1_1,
                "9:16" => Kling3ProParametersAspectRatio2.x9_16,
                _ => null,
            };
        }
    }
}