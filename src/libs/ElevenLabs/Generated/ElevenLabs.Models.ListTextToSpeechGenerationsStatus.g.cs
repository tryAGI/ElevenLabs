
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ListTextToSpeechGenerationsStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Generating,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTextToSpeechGenerationsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTextToSpeechGenerationsStatus value)
        {
            return value switch
            {
                ListTextToSpeechGenerationsStatus.Completed => "completed",
                ListTextToSpeechGenerationsStatus.Failed => "failed",
                ListTextToSpeechGenerationsStatus.Generating => "generating",
                ListTextToSpeechGenerationsStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTextToSpeechGenerationsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListTextToSpeechGenerationsStatus.Completed,
                "failed" => ListTextToSpeechGenerationsStatus.Failed,
                "generating" => ListTextToSpeechGenerationsStatus.Generating,
                "pending" => ListTextToSpeechGenerationsStatus.Pending,
                _ => null,
            };
        }
    }
}