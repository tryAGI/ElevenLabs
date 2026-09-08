
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ListVideoGenerationsStatus
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
    public static class ListVideoGenerationsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVideoGenerationsStatus value)
        {
            return value switch
            {
                ListVideoGenerationsStatus.Completed => "completed",
                ListVideoGenerationsStatus.Failed => "failed",
                ListVideoGenerationsStatus.Generating => "generating",
                ListVideoGenerationsStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVideoGenerationsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListVideoGenerationsStatus.Completed,
                "failed" => ListVideoGenerationsStatus.Failed,
                "generating" => ListVideoGenerationsStatus.Generating,
                "pending" => ListVideoGenerationsStatus.Pending,
                _ => null,
            };
        }
    }
}