
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListImageGenerationsStatus2
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
    public static class ListImageGenerationsStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListImageGenerationsStatus2 value)
        {
            return value switch
            {
                ListImageGenerationsStatus2.Completed => "completed",
                ListImageGenerationsStatus2.Failed => "failed",
                ListImageGenerationsStatus2.Generating => "generating",
                ListImageGenerationsStatus2.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListImageGenerationsStatus2? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListImageGenerationsStatus2.Completed,
                "failed" => ListImageGenerationsStatus2.Failed,
                "generating" => ListImageGenerationsStatus2.Generating,
                "pending" => ListImageGenerationsStatus2.Pending,
                _ => null,
            };
        }
    }
}