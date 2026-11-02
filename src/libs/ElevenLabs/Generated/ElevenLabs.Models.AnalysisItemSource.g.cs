
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalysisItemSource
    {
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalysisItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalysisItemSource value)
        {
            return value switch
            {
                AnalysisItemSource.System => "system",
                AnalysisItemSource.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalysisItemSource? ToEnum(string value)
        {
            return value switch
            {
                "system" => AnalysisItemSource.System,
                "user" => AnalysisItemSource.User,
                _ => null,
            };
        }
    }
}