
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: pending
    /// </summary>
    public enum ContentGenerationStatus
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
    public static class ContentGenerationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentGenerationStatus value)
        {
            return value switch
            {
                ContentGenerationStatus.Completed => "completed",
                ContentGenerationStatus.Failed => "failed",
                ContentGenerationStatus.Generating => "generating",
                ContentGenerationStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentGenerationStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ContentGenerationStatus.Completed,
                "failed" => ContentGenerationStatus.Failed,
                "generating" => ContentGenerationStatus.Generating,
                "pending" => ContentGenerationStatus.Pending,
                _ => null,
            };
        }
    }
}