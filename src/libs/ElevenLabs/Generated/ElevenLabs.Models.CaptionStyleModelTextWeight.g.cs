
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
        x900,
        /// <summary>
        ///
        /// </summary>
        Bold,
        /// <summary>
        ///
        /// </summary>
        Normal,
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
                CaptionStyleModelTextWeight.x900 => "900",
                CaptionStyleModelTextWeight.Bold => "bold",
                CaptionStyleModelTextWeight.Normal => "normal",
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
                "900" => CaptionStyleModelTextWeight.x900,
                "bold" => CaptionStyleModelTextWeight.Bold,
                "normal" => CaptionStyleModelTextWeight.Normal,
                _ => null,
            };
        }
    }
}