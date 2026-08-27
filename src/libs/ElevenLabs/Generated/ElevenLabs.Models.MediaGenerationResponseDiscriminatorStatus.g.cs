
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum MediaGenerationResponseDiscriminatorStatus
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
    public static class MediaGenerationResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MediaGenerationResponseDiscriminatorStatus value)
        {
            return value switch
            {
                MediaGenerationResponseDiscriminatorStatus.Completed => "completed",
                MediaGenerationResponseDiscriminatorStatus.Failed => "failed",
                MediaGenerationResponseDiscriminatorStatus.Generating => "generating",
                MediaGenerationResponseDiscriminatorStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MediaGenerationResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => MediaGenerationResponseDiscriminatorStatus.Completed,
                "failed" => MediaGenerationResponseDiscriminatorStatus.Failed,
                "generating" => MediaGenerationResponseDiscriminatorStatus.Generating,
                "pending" => MediaGenerationResponseDiscriminatorStatus.Pending,
                _ => null,
            };
        }
    }
}