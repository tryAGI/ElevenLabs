
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TTSModelFamily
    {
        /// <summary>
        ///
        /// </summary>
        Flash,
        /// <summary>
        ///
        /// </summary>
        Multilingual,
        /// <summary>
        /// Deprecated: Use flash instead.
        /// </summary>
        Turbo,
        /// <summary>
        ///
        /// </summary>
        V3Conversational,
        /// <summary>
        ///
        /// </summary>
        V4,
        /// <summary>
        ///
        /// </summary>
        V4Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSModelFamilyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSModelFamily value)
        {
            return value switch
            {
                TTSModelFamily.Flash => "flash",
                TTSModelFamily.Multilingual => "multilingual",
                TTSModelFamily.Turbo => "turbo",
                TTSModelFamily.V3Conversational => "v3_conversational",
                TTSModelFamily.V4 => "v4",
                TTSModelFamily.V4Turbo => "v4_turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSModelFamily? ToEnum(string value)
        {
            return value switch
            {
                "flash" => TTSModelFamily.Flash,
                "multilingual" => TTSModelFamily.Multilingual,
                "turbo" => TTSModelFamily.Turbo,
                "v3_conversational" => TTSModelFamily.V3Conversational,
                "v4" => TTSModelFamily.V4,
                "v4_turbo" => TTSModelFamily.V4Turbo,
                _ => null,
            };
        }
    }
}