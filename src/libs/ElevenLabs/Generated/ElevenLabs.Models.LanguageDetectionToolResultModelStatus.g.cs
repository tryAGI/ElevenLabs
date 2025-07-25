
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum LanguageDetectionToolResultModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageDetectionToolResultModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageDetectionToolResultModelStatus value)
        {
            return value switch
            {
                LanguageDetectionToolResultModelStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageDetectionToolResultModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => LanguageDetectionToolResultModelStatus.Success,
                _ => null,
            };
        }
    }
}