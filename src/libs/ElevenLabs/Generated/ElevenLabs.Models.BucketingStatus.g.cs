
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum BucketingStatus
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
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BucketingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BucketingStatus value)
        {
            return value switch
            {
                BucketingStatus.Completed => "completed",
                BucketingStatus.Failed => "failed",
                BucketingStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BucketingStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BucketingStatus.Completed,
                "failed" => BucketingStatus.Failed,
                "pending" => BucketingStatus.Pending,
                _ => null,
            };
        }
    }
}