
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The resolution of the output image.<br/>
    /// Default Value: 1K
    /// </summary>
    public enum Gemini3ProImageRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
        /// <summary>
        ///
        /// </summary>
        x4k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Gemini3ProImageRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Gemini3ProImageRequestResolution value)
        {
            return value switch
            {
                Gemini3ProImageRequestResolution.x1k => "1K",
                Gemini3ProImageRequestResolution.x2k => "2K",
                Gemini3ProImageRequestResolution.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Gemini3ProImageRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => Gemini3ProImageRequestResolution.x1k,
                "2K" => Gemini3ProImageRequestResolution.x2k,
                "4K" => Gemini3ProImageRequestResolution.x4k,
                _ => null,
            };
        }
    }
}