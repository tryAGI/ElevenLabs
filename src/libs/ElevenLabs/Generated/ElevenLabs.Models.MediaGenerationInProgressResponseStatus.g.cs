
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The lifecycle status of the generation. It ends at `completed` or `failed`.
    /// </summary>
    public enum MediaGenerationInProgressResponseStatus
    {
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
    public static class MediaGenerationInProgressResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MediaGenerationInProgressResponseStatus value)
        {
            return value switch
            {
                MediaGenerationInProgressResponseStatus.Generating => "generating",
                MediaGenerationInProgressResponseStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MediaGenerationInProgressResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "generating" => MediaGenerationInProgressResponseStatus.Generating,
                "pending" => MediaGenerationInProgressResponseStatus.Pending,
                _ => null,
            };
        }
    }
}