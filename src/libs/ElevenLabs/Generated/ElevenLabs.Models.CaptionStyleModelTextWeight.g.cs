
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleModelTextWeight
    {
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Bold,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleModelTextWeightExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextWeight value)
        {
            return value switch
            {
                CaptionStyleModelTextWeight.Normal => "normal",
                CaptionStyleModelTextWeight.Bold => "bold",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextWeight? ToEnum(string value)
        {
            return value switch
            {
                "normal" => CaptionStyleModelTextWeight.Normal,
                "bold" => CaptionStyleModelTextWeight.Bold,
                _ => null,
            };
        }
    }
}