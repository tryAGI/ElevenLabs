
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ListTextToSpeechGenerationsStatus2
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
    public static class ListTextToSpeechGenerationsStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTextToSpeechGenerationsStatus2 value)
        {
            return value switch
            {
                ListTextToSpeechGenerationsStatus2.Completed => "completed",
                ListTextToSpeechGenerationsStatus2.Failed => "failed",
                ListTextToSpeechGenerationsStatus2.Generating => "generating",
                ListTextToSpeechGenerationsStatus2.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTextToSpeechGenerationsStatus2? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListTextToSpeechGenerationsStatus2.Completed,
                "failed" => ListTextToSpeechGenerationsStatus2.Failed,
                "generating" => ListTextToSpeechGenerationsStatus2.Generating,
                "pending" => ListTextToSpeechGenerationsStatus2.Pending,
                _ => null,
            };
        }
    }
}