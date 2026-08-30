
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ListVideoGenerationsStatus2
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
    public static class ListVideoGenerationsStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVideoGenerationsStatus2 value)
        {
            return value switch
            {
                ListVideoGenerationsStatus2.Completed => "completed",
                ListVideoGenerationsStatus2.Failed => "failed",
                ListVideoGenerationsStatus2.Generating => "generating",
                ListVideoGenerationsStatus2.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVideoGenerationsStatus2? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListVideoGenerationsStatus2.Completed,
                "failed" => ListVideoGenerationsStatus2.Failed,
                "generating" => ListVideoGenerationsStatus2.Generating,
                "pending" => ListVideoGenerationsStatus2.Pending,
                _ => null,
            };
        }
    }
}