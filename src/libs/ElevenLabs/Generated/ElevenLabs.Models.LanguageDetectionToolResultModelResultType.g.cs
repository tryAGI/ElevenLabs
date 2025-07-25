
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: language_detection_success
    /// </summary>
    public enum LanguageDetectionToolResultModelResultType
    {
        /// <summary>
        /// 
        /// </summary>
        LanguageDetectionSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageDetectionToolResultModelResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageDetectionToolResultModelResultType value)
        {
            return value switch
            {
                LanguageDetectionToolResultModelResultType.LanguageDetectionSuccess => "language_detection_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageDetectionToolResultModelResultType? ToEnum(string value)
        {
            return value switch
            {
                "language_detection_success" => LanguageDetectionToolResultModelResultType.LanguageDetectionSuccess,
                _ => null,
            };
        }
    }
}