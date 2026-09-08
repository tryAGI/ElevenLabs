
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ListImageGenerationsStatus
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
    public static class ListImageGenerationsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListImageGenerationsStatus value)
        {
            return value switch
            {
                ListImageGenerationsStatus.Completed => "completed",
                ListImageGenerationsStatus.Failed => "failed",
                ListImageGenerationsStatus.Generating => "generating",
                ListImageGenerationsStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListImageGenerationsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListImageGenerationsStatus.Completed,
                "failed" => ListImageGenerationsStatus.Failed,
                "generating" => ListImageGenerationsStatus.Generating,
                "pending" => ListImageGenerationsStatus.Pending,
                _ => null,
            };
        }
    }
}